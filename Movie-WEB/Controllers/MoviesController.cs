using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movie_DataAccess.Services.Interface;
using Movie_WEB.Models.ViewModels;
using Movie_Core.Entities.Abstract;
using Movie_Core.Entities.Concrete;
using Movie_Core.DTO_s.MovieDTO;
using Microsoft.AspNetCore.Authorization;
using Movie_DataAccess.Services.Concrete;

namespace Movie_WEB.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public MoviesController(IMovieRepository movieRepository, IMapper mapper, ICommentRepository commentRepository)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
            _commentRepository = commentRepository;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var movies = await _movieRepository.GetFilteredListAsync
                (
                    select: x => new MovieVM
                    {
                        Id = x.Id,
                        MovieName = x.MovieName,
                        Description = x.Description,
                        Director = x.Director,
                        Genre = x.Genre,
                        Cast = x.Cast,
                        Duration = x.Duration,
                        ReleaseDate = x.ReleaseDate,
                        ImdbRating = x.ImdbRating,
                        ImagePath = x.ImagePath,
                        TrailerPath = x.TrailerPath,
                    },
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(z => z.ImdbRating)
                );
            return View(movies);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> MovieDetail(int id)
        {
            if (id > 0)
            {
                var movie = await _movieRepository.GetByIdAsync(id);
                if (movie != null)
                {
                    var model = _mapper.Map<MovieDetailDTO>(movie);

                    // Bu filmle ilgili yorumları al
                    var comments = await _commentRepository.GetFilteredListAsync(
                        select: c => new CommentVM
                        {
                            UserName = c.UserName,
                            UserComment = c.UserComment
                        },
                        where: c => c.MovieId == id && c.Status != Status.Passive
                    );

                    model.Comments = comments.ToList();

                    return View(model);
                }
            }
            TempData["Error"] = "Movie not found!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> MovieDetail(int id, string userName, string userComment)
        {
            if (id > 0)
            {
                var movie = await _movieRepository.GetByIdAsync(id);
                if (movie != null)
                {
                    var model = _mapper.Map<MovieDetailDTO>(movie);

                    var comments = await _commentRepository.GetFilteredListAsync(
                        select: c => new CommentVM
                        {
                            UserName = c.UserName,
                            UserComment = c.UserComment
                        },
                        where: c => c.MovieId == id && c.Status != Status.Passive
                    );

                    model.Comments = comments.ToList();

                    // Yorum ekleme işlemi
                    if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(userComment))
                    {
        
                        var comment = new Comment
                        {
                            UserName = userName,
                            UserComment = userComment,
                            MovieId = id,
                            Status = Status.Active // Varsayılan olarak aktif durumda
                        };

                        await _commentRepository.AddAsync(comment);

                        // Yeni yorum eklendikten sonra, sayfayı yenilemek için yönlendirme yap
                        return RedirectToAction("MovieDetail", new { id = id });
                    }

                    return View(model);
                }
            }
            TempData["Error"] = "Movie not found!";
            return RedirectToAction("Index");
        }



    }
}