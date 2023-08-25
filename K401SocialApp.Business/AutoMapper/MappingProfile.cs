using System;
using AutoMapper;
using K401SocialApp.Entities.Concrete;
using K401SocialApp.Entities.Dtos.CommentDtos;
using K401SocialApp.Entities.Dtos.PostDtos;
using K401SocialApp.Entities.Dtos.UserDtos;

namespace K401SocialApp.Business.AutoMapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<UserRegisterDto, User>();

			CreateMap<PostShareDto, Post>();

			CreateMap<Post, PostDetailDto>()
				.ForMember(x=>x.Like, a=>a.MapFrom(z=>z.Reactions.Where(x=>x.IsLike==true).Count()))
				.ForMember(x=>x.Dislike, a=>a.MapFrom(z=>z.Reactions.Where(x=>x.IsLike==false).Count()));
            CreateMap<User, UserPostDto>();

			CreateMap<Comment, CommentUserDto>();

			CreateMap<CommentCreateDto, Comment>();
		}
	}
}

