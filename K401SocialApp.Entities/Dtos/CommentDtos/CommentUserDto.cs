using System;
using K401SocialApp.Entities.Dtos.UserDtos;

namespace K401SocialApp.Entities.Dtos.CommentDtos
{
	public class CommentUserDto
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public string CommentDate { get; set; }
		public UserPostDto User { get; set; }
	}
}

