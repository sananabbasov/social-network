using System;
using K401SocialApp.Core.DataAccess;
using K401SocialApp.Entities.Concrete;

namespace K401SocialApp.DataAccess.Abstract
{
	public interface IReactionDal : IRepositoryBase<Reaction>
	{
		void LikePost(int userId, int postId);
		void DisLikePost(int userId, int postId);
    }
}

