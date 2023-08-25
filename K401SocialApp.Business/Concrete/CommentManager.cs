using System;
using AutoMapper;
using K401SocialApp.Business.Abstract;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Core.Utilities.Results.Concrete;
using K401SocialApp.DataAccess.Abstract;
using K401SocialApp.Entities.Concrete;
using K401SocialApp.Entities.Dtos.CommentDtos;

namespace K401SocialApp.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        private readonly IMapper _mapper;
        public CommentManager(ICommentDal commentDal, IMapper mapper)
        {
            _commentDal = commentDal;
            _mapper = mapper;
        }

        public IResult AddComment(int userId, CommentCreateDto commentCreate)
        {
            var result = _mapper.Map<Comment>(commentCreate);
            result.UserId = userId;

            _commentDal.Add(result);

            return new SuccessResult();
        }
    }
}

