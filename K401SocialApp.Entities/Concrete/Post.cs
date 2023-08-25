using System;
using K401SocialApp.Core.Entities.Abstract;

namespace K401SocialApp.Entities.Concrete
{
	public class Post : IEntity
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public DateTime PostedDate { get; set; }
		public string PhotoUrl { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public bool IsActive { get; set; }
		public List<Comment> Comments { get; set; }
		public List<Reaction> Reactions { get; set; }
	}
}

