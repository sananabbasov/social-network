using System;
namespace K401SocialApp.Entities.Dtos.UserDtos
{
	public class UserProfileDto
	{
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
		public string CoverPhoto { get; set; }
    }
}

