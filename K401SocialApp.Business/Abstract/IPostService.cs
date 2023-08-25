using System;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Entities.Dtos.PostDtos;

namespace K401SocialApp.Business.Abstract
{
	public interface IPostService
	{
		IResult AddPost(int id, PostShareDto postShare);
		IDataResult<PostDetailDto> GetPostDetailById(int postId);
	}
}

