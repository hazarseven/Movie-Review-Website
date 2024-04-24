using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movie_DataAccess.Services.Interface;
using Movie_WEB.Models.ViewModels;
using Movie_Core.Entities.Abstract;
using Movie_Core.Entities.Concrete;
using Movie_Core.DTO_s.MovieDTO;
using Microsoft.AspNetCore.Authorization;

namespace Movie_WEB.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MoviesController(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
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

		[AllowAnonymous]
		public async Task<IActionResult> MovieDetail(int id)
		{
			if (id > 0)
			{
				var movie = await _movieRepository.GetByIdAsync(id);
				if (movie != null)
				{
					var model = _mapper.Map<MovieDetailDTO>(movie);
					return View(model);
				}
			}
			TempData["Error"] = "Movie not found!";
			return RedirectToAction("Index");
		}
	}
}