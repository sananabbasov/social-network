using System;
using System.ComponentModel.DataAnnotations.Schema;
using K401SocialApp.Core.Entities.Abstract;

namespace K401SocialApp.Entities.Concrete
{
	public class Comment : IEntity
    {
		public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
		public int PostId { get; set; }
		public Post Post { get; set; }
		public string Content { get; set; }
	}
}

