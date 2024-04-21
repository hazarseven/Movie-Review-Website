using Microsoft.AspNetCore.Mvc;
using Movie_Core.DTO_s.CommentDTO;
using Movie_DataAccess.Services.Interface;
using Movie_Core.Entities.Abstract;
using AutoMapper;
using Movie_Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Movie_DataAccess.Services.Concrete;
using Movie_WEB.Models.ViewModels;

namespace Movie_WEB.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly ITvSeriesRepository _tvSeriesRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CommentsController(ICommentRepository commentRepository, IMovieRepository movieRepository, ITvSeriesRepository tvSeriesRepository, IUserRepository userRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _movieRepository = movieRepository;
            _tvSeriesRepository = tvSeriesRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> MovieComments()
        {
            var movieComments = await _commentRepository.GetFilteredListAsync
                (
                    select: x => new CommentVM
                    {
                        MovieId = x.MovieId,
                        MovieName = x.Movie.MovieName,
                        UserComment = x.UserComment,
                        UserName = x.UserName,
                    },

                    where: x => x.Status != Status.Passive
                );
            return View(movieComments);
        }

        [AllowAnonymous]
        public async Task<IActionResult> TvSeriesComments()
        {
            var tvSeriesComments = await _commentRepository.GetFilteredListAsync
                (
                    select: x => new CommentVM
                    {
                        TvSeriesId = x.TvSeriesId,
                        TvSeriesName = x.TvSeries.TvSeriesName,
                        UserComment = x.UserComment,
                        UserName = x.UserName,
                    },

                    where: x => x.Status != Status.Passive
                );
            return View(tvSeriesComments);
        }

        [Authorize(Roles = "editor, member")]
        public async Task<IActionResult> AddComment()
        {
            var model = new AddCommentDTO()
            {
                Movies = await _movieRepository.GetByDefaultsAsync(x => x.Status != Status.Passive),
                TvSeries = await _tvSeriesRepository.GetByDefaultsAsync(x => x.Status != Status.Passive),
                Users = await _userRepository.GetByDefaultsAsync(x => x.Status != Status.Passive)
            };

            return View(model);
        }


        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = "editor, member")]
        public async Task<IActionResult> AddComment(AddCommentDTO model)
        {
            model.Movies = await _movieRepository.GetByDefaultsAsync(x => x.Status != Status.Passive);
            model.TvSeries = await _tvSeriesRepository.GetByDefaultsAsync(x => x.Status != Status.Passive);
            model.Users = await _userRepository.GetByDefaultsAsync(x => x.Status != Status.Passive);

            if (ModelState.IsValid)
            {
                var comment = new Comment
                {
                    UserComment = model.UserComment,
                    UserName = model.UserName,
                    MovieId = model.MovieId,
                    TvSeriesId = model.TvSeriesId,
                    UserId = (int)model.UserId
                };
                await _commentRepository.AddAsync(comment);
                TempData["Success"] = "Your comment is saved.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Please follow the rules below!";
            return View(model);
        }
    }
}
