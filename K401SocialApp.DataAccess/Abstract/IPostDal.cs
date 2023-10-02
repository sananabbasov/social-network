using System;
using K401SocialApp.Core.DataAccess;
using K401SocialApp.Entities.Concrete;

namespace K401SocialApp.DataAccess.Abstract
{
	public interface IPostDal : IRepositoryBase<Post>
    {
		Post GetPostById(int postId);
		List<Post> GetAllPosts();
	}
}

