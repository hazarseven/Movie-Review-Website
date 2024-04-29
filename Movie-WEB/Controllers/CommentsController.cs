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

        public CommentsController(ICommentRepository commentRepository, IMovieRepository movieRepository, ITvSeriesRepository tvSeriesRepository, IUserRepository userRepository)
        {
            _commentRepository = commentRepository;
            _movieRepository = movieRepository;
            _tvSeriesRepository = tvSeriesRepository;
            _userRepository = userRepository;
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
        public IActionResult AddComment() => View();


        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = "editor, member")]
        public async Task<IActionResult> AddComment(AddCommentDTO model)
        {
            
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

        [Authorize(Roles = "editor, member")]
        public async Task<IActionResult> DeleteComment(int id)
        {
			if (id > 0)
            {
				var comment = await _commentRepository.GetByIdAsync(id);
				if (comment != null)
                {
					await _commentRepository.DeleteAsync(comment);
                    TempData["Success"] = "Comment deleted successfully";
					return RedirectToAction("Index");
				}
			}
            TempData["Error"] = "Comment not found!";
			return RedirectToAction("Index");
		}
    }
}
