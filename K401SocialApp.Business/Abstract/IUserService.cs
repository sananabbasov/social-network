using System;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Entities.Dtos.UserDtos;

namespace K401SocialApp.Business.Abstract
{
	public interface IUserService
	{
		IResult Login(UserLoginDto userLogin);
		IResult Register(UserRegisterDto userRegister);
		IResult VerifyEmail(string email, string token);
		IResult SendEmail();
		IDataResult<UserProfileDto> GetUserProfil(int userId);
		IResult AddFriend(int userId, int friendId);
	}
}

