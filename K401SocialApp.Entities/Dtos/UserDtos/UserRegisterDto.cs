using System;
using K401SocialApp.Entities.Enums;

namespace K401SocialApp.Entities.Dtos.UserDtos
{
	public class UserRegisterDto
	{
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime BirtDay { get; set; }
        public Gender Gender { get; set; }
    }
}

