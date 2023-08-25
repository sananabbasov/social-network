using System;
using K401SocialApp.Core.Entities.Abstract;

namespace K401SocialApp.Core.Entities.Concrete
{
	public class AppUserRole : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public AppUser User { get; set; }
		public int RoleId { get; set; }
		public Role Role { get; set; }
	}
}

