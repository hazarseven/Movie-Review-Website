using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movie_Core.Entities.Abstract;
using Movie_DataAccess.Services.Interface;
using Movie_WEB.Models.ViewModels;

namespace Movie_WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "editor")]
    public class DashboardController : Controller
    {
		private readonly IMovieRepository _movieRepository;
		private readonly ITvSeriesRepository _tvSeriesRepository;

		public DashboardController(IMovieRepository movieRepository, ITvSeriesRepository tvSeriesRepository)
        {
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
					orderBy: x => x.OrderByDescending(z => z.MovieName)
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
				   orderBy: x => x.OrderByDescending(z => z.TvSeriesName)
			   );

			var movieSeries = new MovieSeriesVM
			{
				Movies = movies,
				TvSeries = tvSeries
			};

			return View(movieSeries);
		}
	}
}
