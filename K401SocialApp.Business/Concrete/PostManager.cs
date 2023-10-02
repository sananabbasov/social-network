using System;
using AutoMapper;
using K401SocialApp.Business.Abstract;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Core.Utilities.Results.Concrete;
using K401SocialApp.DataAccess.Abstract;
using K401SocialApp.Entities.Concrete;
using K401SocialApp.Entities.Dtos.PostDtos;
using static MassTransit.MessageHeaders;

namespace K401SocialApp.Business.Concrete
{
    public class PostManager : IPostService
    {
        private readonly IPostDal _postDal;
        private readonly IMapper _mapper;

        public PostManager(IPostDal postDal, IMapper mapper)
        {
            _postDal = postDal;
            _mapper = mapper;
        }

        public IResult AddPost(int id, PostShareDto postShare)
        {
            var mapper = _mapper.Map<Post>(postShare);
            mapper.UserId = id;
            mapper.PostedDate = DateTime.Now;
            mapper.IsActive = true;

            _postDal.Add(mapper);
            return new SuccessResult();
        }

        public IDataResult<PostDetailDto> GetPostDetailById(int postId)
        {
            var post = _postDal.GetPostById(postId);
            var result = _mapper.Map<PostDetailDto>(post);

            return new SuccessDataResult<PostDetailDto>(result);
        }

        public IDataResult<List<PostDetailDto>> UserPosts()
        {
            var posts = _postDal.GetAllPosts().OrderByDescending(x=>x.Id);
            var result = _mapper.Map<List<PostDetailDto>>(posts);
            return new SuccessDataResult<List<PostDetailDto>>(result);
        }
    }
}

