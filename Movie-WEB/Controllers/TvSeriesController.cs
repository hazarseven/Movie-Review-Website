using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movie_Core.DTO_s.TvSeriesDTO;
using Movie_Core.Entities.Abstract;
using Movie_Core.Entities.Concrete;
using Movie_DataAccess.Services.Interface;
using Movie_WEB.Models.ViewModels;

namespace Movie_WEB.Controllers
{
    public class TvSeriesController : Controller
    {
        private readonly ITvSeriesRepository _tvSeriesRepository;
        private readonly IMapper _mapper;

        public TvSeriesController(ITvSeriesRepository tvSeriesRepository, IMapper mapper)
        {
            _tvSeriesRepository = tvSeriesRepository;
            _mapper = mapper;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
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
            return View(tvSeries);
        }


        [AllowAnonymous]
        public async Task<IActionResult> TvSeriesDetail(int id)
        {
            if(id > 0)
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