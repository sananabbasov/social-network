using System;
using K401SocialApp.Core.Utilities.Results.Abstract;

namespace K401SocialApp.Business.Abstract
{
	public interface IReactionService
	{
		IResult LikeReaction(int userId, int postId);
		IResult DisLikeReaction(int userId, int postId);
    }
}

