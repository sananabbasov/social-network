using System;
using K401SocialApp.Core.Entities.Abstract;

namespace K401SocialApp.Entities.Concrete
{
	public class Reaction : IEntity
    {
		public int Id { get; set; }
		public bool IsLike { get; set; }
		public int PostId { get; set; }
		public Post Post { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
	}
}

