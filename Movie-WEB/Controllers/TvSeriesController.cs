using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movie_Core.DTO_s.MovieDTO;
using Movie_Core.DTO_s.TvSeriesDTO;
using Movie_Core.Entities.Abstract;
using Movie_Core.Entities.Concrete;
using Movie_DataAccess.Services.Concrete;
using Movie_DataAccess.Services.Interface;
using Movie_WEB.Models.ViewModels;

namespace Movie_WEB.Controllers
{
    public class TvSeriesController : Controller
    {
        private readonly ITvSeriesRepository _tvSeriesRepository;
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public TvSeriesController(ITvSeriesRepository tvSeriesRepository, IMapper mapper, ICommentRepository commentRepository)
        {
            _tvSeriesRepository = tvSeriesRepository;
            _mapper = mapper;
            _commentRepository = commentRepository;
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


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> TvSeriesDetail(int id)
        {
            if (id > 0)
            {
                var tvSeries = await _tvSeriesRepository.GetByIdAsync(id);
                if (tvSeries != null)
                {
                    var model = _mapper.Map<TvSeriesDetailDTO>(tvSeries);

                    var comments = await _commentRepository.GetFilteredListAsync(
                        select: c => new CommentVM
                        {
                            UserName = c.UserName,
                            UserComment = c.UserComment
                        },
                        where: c => c.TvSeriesId == id && c.Status != Status.Passive
                    );

                    model.Comments = comments.ToList();

                    return View(model);
                }
            }
            TempData["Error"] = "TvSeries not found!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> TvSeriesDetail(int id, string userName, string userComment)
        {
            if (id > 0)
            {
                var tvSeries = await _tvSeriesRepository.GetByIdAsync(id);
                if (tvSeries != null)
                {
                    var model = _mapper.Map<TvSeriesDetailDTO>(tvSeries);

                    var comments = await _commentRepository.GetFilteredListAsync(
                        select: c => new CommentVM
                        {
                            UserName = User.Identity.Name,
                            UserComment = c.UserComment
                        },
                        where: c => c.TvSeriesId == id && c.Status != Status.Passive
                    );

                    model.Comments = comments.ToList();


                    if (!string.IsNullOrWhiteSpace(User.Identity.Name) && !string.IsNullOrWhiteSpace(userComment))
                    {

                        var comment = new Comment
                        {
                            UserName = User.Identity.Name,
                            UserComment = userComment,
							TvSeriesId = id,
                            Status = Status.Active 
                        };

                        if (comments.Any(x => x.UserName == User.Identity.Name))
                        {
                            TempData["Error"] = "You have already commented!";
                            return RedirectToAction("TvSeriesDetail", new { id = id });
                        }

                        await _commentRepository.AddAsync(comment);

                        return RedirectToAction("TvSeriesDetail", new { id = id });
                    }
                    
                    return View(model);
                }
            }
            TempData["Error"] = "TvSeries not found!";
            return RedirectToAction("Index");
        }

     
    }
}