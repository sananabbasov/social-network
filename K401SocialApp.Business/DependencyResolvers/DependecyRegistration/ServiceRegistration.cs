using System;
using AutoMapper;
using K401SocialApp.Business.Abstract;
using K401SocialApp.Business.AutoMapper;
using K401SocialApp.Business.Concrete;
using K401SocialApp.Core.Utilities.EmailHelper;
using K401SocialApp.DataAccess.Abstract;
using K401SocialApp.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace K401SocialApp.Business.DependencyResolvers.DependecyRegistration
{
	public static class ServiceRegistration
	{
		public static void Create(this IServiceCollection services)
		{
            services.AddScoped<AppDbContext>();

			services.AddScoped<IUserDal, EfUserDal>();
			services.AddScoped<IUserService, UserManager>();

            services.AddScoped<IPostDal, EfPostDal>();
            services.AddScoped<IPostService, PostManager>();

            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IReactionDal, EfReactionDal>();
            services.AddScoped<IReactionService, ReactionManager>();

            services.AddTransient<IEmailSender, EmailSender>();


            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
	}
}

