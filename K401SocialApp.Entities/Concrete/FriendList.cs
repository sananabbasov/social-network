using System;
using System.ComponentModel.DataAnnotations.Schema;
using K401SocialApp.Core.Entities.Abstract;

namespace K401SocialApp.Entities.Concrete
{
	public class FriendList : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
        public int FriendId { get; set; }
		public User Friend { get; set; }
	}
}

