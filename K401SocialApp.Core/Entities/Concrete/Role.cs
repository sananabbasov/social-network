using System;
using K401SocialApp.Core.Entities.Abstract;

namespace K401SocialApp.Core.Entities.Concrete
{
	public class Role : IEntity
	{
		public int Id { get; set; }
		public string RoleName { get; set; }
	}
}

