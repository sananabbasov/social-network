using System;
namespace K401SocialApp.Entities.Dtos.PostDtos
{
	public class PostListDto
	{
        public int Id { get; set; }
        public string Content { get; set; }
        public string PostedDate { get; set; }
        public string PhotoUrl { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
    }
}

