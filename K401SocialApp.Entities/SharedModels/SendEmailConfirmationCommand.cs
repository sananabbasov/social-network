using System;
namespace K401SocialApp.Entities.SharedModels
{
	public class SendEmailConfirmationCommand
    {
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Token { get; set; }
	}
}

