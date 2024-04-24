using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movie_Core.DTO_s.MovieDTO;
using Movie_Core.DTO_s.TvSeriesDTO;
using Movie_Core.Entities.Abstract;
using Movie_Core.Entities.Concrete;
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
		private readonly IMapper _mapper;

		public DashboardController(IMovieRepository movieRepository, ITvSeriesRepository tvSeriesRepository, IMapper mapper)
        {
			_movieRepository = movieRepository;
			_tvSeriesRepository = tvSeriesRepository;
			_mapper = mapper;
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

		[Authorize(Roles = "editor")]
		public IActionResult AddMovie()
		{
			return View();
		}

		[HttpPost]
		[Authorize(Roles = "editor")]
		public async Task<IActionResult> AddMovie(AddMovieDTO model)
		{
			if (ModelState.IsValid)
			{
				var movie = _mapper.Map<Movie>(model);
				await _movieRepository.AddAsync(movie);
				TempData["Success"] = "Movie added successfully";
				return RedirectToAction("Index");
			}
			TempData["Error"] = "Please follow the rules below!";
			return View(model);
		}

		[Authorize(Roles = "editor")]

		public async Task<IActionResult> UpdateMovie(int id)
		{
			if (id > 0)
			{
				var movie = await _movieRepository.GetByIdAsync(id);
				if (movie != null)
				{
					var model = _mapper.Map<UpdateMovieDTO>(movie);
					return View(model);
				}
			}
			TempData["Error"] = "Movie not found!";
			return RedirectToAction("Index");
		}

		[HttpPost]
		[Authorize(Roles = "editor")]

		public async Task<IActionResult> UpdateMovie(UpdateMovieDTO model)
		{
			if (ModelState.IsValid)
			{
				var movie = _mapper.Map<Movie>(model);
				await _movieRepository.UpdateAsync(movie);
				TempData["Success"] = "Movie updated successfully";
				return RedirectToAction("Index");
			}
			TempData["Error"] = "Please follow the rules below!";
			return View(model);
		}

		[Authorize(Roles = "editor")]
		public async Task<IActionResult> DeleteMovie(int id)
		{
			if (id > 0)
			{
				var movie = await _movieRepository.GetByIdAsync(id);
				if (movie != null)
				{
					await _movieRepository.DeleteAsync(movie);
					TempData["Success"] = "Movie deleted successfully";
					return RedirectToAction("Index");
				}
			}
			TempData["Error"] = "Movie not found!";
			return RedirectToAction("Index");
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

		[Authorize(Roles = "editor")]
		public IActionResult AddTvSeries()
		{
			return View();
		}


		[HttpPost]
		[Authorize(Roles = "editor")]
		public async Task<IActionResult> AddTvSeries(AddTvSeriesDTO model)
		{
			if (ModelState.IsValid)
			{
				var tvSeries = _mapper.Map<TvSeries>(model);
				await _tvSeriesRepository.AddAsync(tvSeries);
				TempData["Success"] = "Tv Series added successfully";
				return RedirectToAction("Index");
			}
			TempData["Error"] = "Please follow the rules below!";
			return View(model);
		}


		[Authorize(Roles = "editor")]
		public async Task<IActionResult> UpdateTvSeries(int id)
		{
			var tvSeries = await
				_tvSeriesRepository.GetByIdAsync(id);
			if (tvSeries != null)
			{
				var model = _mapper.Map<UpdateTvSeriesDTO>(tvSeries);
				return View(model);
			}
			TempData["Error"] = "TvSeries not found";
			return RedirectToAction("Index");
		}




		[HttpPost]
		[Authorize(Roles = "editor")]
		public async Task<IActionResult> UpdateTvSeries(UpdateTvSeriesDTO model)
		{
			if (ModelState.IsValid)
			{
				var tvSeries = _mapper.Map<TvSeries>(model);
				await _tvSeriesRepository.UpdateAsync(tvSeries);
				TempData["Success"] = "Tv Series updated successfully";
				return RedirectToAction("Index");
			}
			TempData["Error"] = "Please follow the rules below!";
			return View(model);
		}


		[Authorize(Roles = "editor")]
		public async Task<IActionResult> DeleteTvSeries(int id)
		{
			if (id > 0)
			{
				var tvSeries = await _tvSeriesRepository.GetByIdAsync(id);
				if (tvSeries != null)
				{
					await _tvSeriesRepository.DeleteAsync(tvSeries);
					TempData["Success"] = "Tv Series deleted successfully";
					return RedirectToAction("Index");
				}
			}
			TempData["Error"] = "Tv Series not found";
			return RedirectToAction("Index");
		}

		[AllowAnonymous]
		public async Task<IActionResult> TvSeriesDetail(int id)
		{
			if (id > 0)
			{
				var tvSeries = await _tvSeriesRepository.GetByIdAsync(id);
				if (tvSeries != null)
				{
					var model = _mapper.Map<TvSeriesDetailDTO>(tvSeries);
					return View(model);
				}
			}
			TempData["Error"] = "Tv Series not found";
			return RedirectToAction("Index");
		}
	}
}
