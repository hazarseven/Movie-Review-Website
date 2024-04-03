using Autofac;
using AutoMapper;
using Movie_DataAccess.AutoMapper;
using Movie_DataAccess.Services.Concrete;
using Movie_DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieRepository>().As<IMovieRepository>
              ().InstancePerLifetimeScope();
            builder.RegisterType<TvSeriesRepository>().As<ITvSeriesRepository>
              ().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>
              ().InstancePerLifetimeScope();
            builder.RegisterType<CommentRepository>().As<ICommentRepository>
              ().InstancePerLifetimeScope();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapping());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            builder.RegisterInstance<IMapper>(mapper);


        }
    }
}
