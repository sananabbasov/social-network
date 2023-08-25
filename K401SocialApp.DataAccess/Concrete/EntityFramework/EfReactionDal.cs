using System;
using K401SocialApp.Core.DataAccess.EntityFramework;
using K401SocialApp.DataAccess.Abstract;
using K401SocialApp.Entities.Concrete;

namespace K401SocialApp.DataAccess.Concrete.EntityFramework
{
    public class EfReactionDal : EfRepositoryBase<Reaction, AppDbContext>, IReactionDal
    {
        public void DisLikePost(int userId, int postId)
        {
            using var context = new AppDbContext();
            var reaction = context.Reactions.FirstOrDefault(x => x.UserId == userId && x.PostId == postId);

            if (reaction == null)
            {
                Reaction res = new()
                {
                    PostId = postId,
                    UserId = userId,
                    IsLike = true
                };
                context.Reactions.Add(res);
                context.SaveChanges();
            }
            else if (reaction.IsLike)
            {
                reaction.IsLike = false;
                context.Reactions.Update(reaction);
                context.SaveChanges();
            }
            else
            {
                context.Reactions.Remove(reaction);
                context.SaveChanges();
            }
        }

        public void LikePost(int userId, int postId)
        {
            using var context = new AppDbContext();
            var reaction = context.Reactions.FirstOrDefault(x => x.UserId == userId && x.PostId == postId);

            if (reaction == null)
            {
                Reaction res = new()
                {
                    PostId = postId,
                    UserId = userId,
                    IsLike = true
                };
                context.Reactions.Add(res);
                context.SaveChanges();
            }
            else if (reaction.IsLike == false)
            {
                reaction.IsLike = true;
                context.Reactions.Update(reaction);
                context.SaveChanges();
            }
            else
            {
                context.Reactions.Remove(reaction);
                context.SaveChanges();
            }

        }
    }
}

