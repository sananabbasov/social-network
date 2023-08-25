using System;
using K401SocialApp.Core.Entities.Abstract;

namespace K401SocialApp.Core.Entities.Concrete
{
	public class AppUser : IEntity
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
		public bool EmailConfirmed { get; set; }
		public string EmailToken { get; set; }
		public DateTime TokenEndDate { get; set; }
	}
}

