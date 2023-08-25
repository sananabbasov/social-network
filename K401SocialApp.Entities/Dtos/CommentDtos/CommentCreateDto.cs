using System;

namespace K401SocialApp.Entities.Dtos.CommentDtos
{
	public class CommentCreateDto
	{
        public int PostId { get; set; }
        public string Content { get; set; }
    }
}

