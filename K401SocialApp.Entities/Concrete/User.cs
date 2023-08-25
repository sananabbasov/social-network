using System;
using K401SocialApp.Core.Entities.Concrete;
using K401SocialApp.Entities.Enums;

namespace K401SocialApp.Entities.Concrete
{
	public class User : AppUser
	{
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Avatar { get; set; }
		public string CoverPhoto { get; set; }
		public string UserName { get; set; }
		public DateTime BirtDay { get; set; }
		public Gender Gender { get; set; }
		public List<FriendList> FriendLists { get; set; }
	}
}

