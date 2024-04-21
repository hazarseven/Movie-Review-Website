using AutoMapper;
using Movie_Core.DTO_s.CommentDTO;
using Movie_Core.DTO_s.MovieDTO;
using Movie_Core.DTO_s.TvSeriesDTO;
using Movie_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Movie, AddMovieDTO>().ReverseMap();
            CreateMap<Movie, UpdateMovieDTO>().ReverseMap();
            CreateMap<Movie, MovieDetailDTO>().ReverseMap();

            CreateMap<TvSeries, AddTvSeriesDTO>().ReverseMap();
            CreateMap<TvSeries, UpdateTvSeriesDTO>().ReverseMap();
            CreateMap<TvSeries, TvSeriesDetailDTO>().ReverseMap();



        }
    }
}
