using System;
using K401SocialApp.Entities.Concrete;
using K401SocialApp.Entities.Dtos.CommentDtos;
using K401SocialApp.Entities.Dtos.UserDtos;

namespace K401SocialApp.Entities.Dtos.PostDtos
{
	public class PostDetailDto
	{
        public int Id { get; set; }
        public string Content { get; set; }
        public string PostedDate { get; set; }
        public string PhotoUrl { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public UserPostDto User { get; set; }
        public List<CommentUserDto> Comments { get; set; }
    }
}

