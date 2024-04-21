using Microsoft.AspNetCore.Mvc;
using Movie_Core.Entities.Abstract;
using Movie_DataAccess.Services.Concrete;
using Movie_DataAccess.Services.Interface;
using Movie_WEB.Models;
using Movie_WEB.Models.ViewModels;
using System.Diagnostics;

namespace Movie_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieRepository _movieRepository;
        private readonly ITvSeriesRepository _tvSeriesRepository;

        public HomeController(ILogger<HomeController> logger, IMovieRepository movieRepository, ITvSeriesRepository tvSeriesRepository)
        {
            _logger = logger;
            _movieRepository = movieRepository;
            _tvSeriesRepository = tvSeriesRepository;
        }

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

            var tvSeries = await _tvSeriesRepository.GetFilteredListAsync
               (
                   select: x => new TvSeriesVM
                   {
                       Id = x.Id,
                       TvSeriesName = x.TvSeriesName,
                       Description = x.Description,
                       Director = x.Director,
                       Genre = x.Genre,
                       Cast = x.Cast,
                       ReleaseDate = x.ReleaseDate,
                       ImdbRating = x.ImdbRating,
                       ImagePath = x.ImagePath,
                       TrailerPath = x.TrailerPath
                   },
                   where: x => x.Status != Status.Passive,
                   orderBy: x => x.OrderByDescending(z => z.ImdbRating)
               );

            var movieSeries = new MovieSeriesVM
            {
                Movies = movies,
                TvSeries = tvSeries
            };

            return View(movieSeries);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
