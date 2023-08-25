using System;
using K401SocialApp.Business.Abstract;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Core.Utilities.Results.Concrete;
using K401SocialApp.DataAccess.Abstract;

namespace K401SocialApp.Business.Concrete
{
    public class ReactionManager : IReactionService
    {
        private readonly IReactionDal _reactionDal;

        public ReactionManager(IReactionDal reactionDal)
        {
            _reactionDal = reactionDal;
        }

        public IResult DisLikeReaction(int userId, int postId)
        {
            _reactionDal.DisLikePost(userId, postId);
            return new SuccessResult();
        }

        public IResult LikeReaction(int userId, int postId)
        {
            _reactionDal.LikePost(userId, postId);
            return new SuccessResult();
        }
    }
}

