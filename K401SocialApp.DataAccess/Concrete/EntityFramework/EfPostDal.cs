using System;
using K401SocialApp.Core.DataAccess.EntityFramework;
using K401SocialApp.DataAccess.Abstract;
using K401SocialApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace K401SocialApp.DataAccess.Concrete.EntityFramework
{
    public class EfPostDal : EfRepositoryBase<Post, AppDbContext>, IPostDal
    {
        public List<Post> GetAllPosts()
        {
            using var context = new AppDbContext();
            var posts = context.Posts.Include(x => x.Reactions).Include(a => a.User).Include(a => a.Comments).ThenInclude(x => x.User).ToList();
            return posts;
        }

        public Post GetPostById(int postId)
        {
            using var context = new AppDbContext();
            var comment = context.Posts.Include(x=>x.Reactions).Include(a=>a.User).Include(a=>a.Comments).ThenInclude(x=>x.User).FirstOrDefault(x=>x.Id == postId);
            return comment;
        }
    }
}

