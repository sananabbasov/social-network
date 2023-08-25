using System;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Entities.Dtos.CommentDtos;

namespace K401SocialApp.Business.Abstract
{
	public interface ICommentService
	{
		IResult AddComment(int userId,CommentCreateDto commentCreate);
	}
}

