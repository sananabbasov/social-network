using System;
using AutoMapper;
using K401SocialApp.Business.Abstract;
using K401SocialApp.Business.Constants;
using K401SocialApp.Core.Utilities.Business;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Core.Utilities.Results.Concrete;
using K401SocialApp.Core.Utilities.Security.Hashing;
using K401SocialApp.Core.Utilities.Security.Jwt;
using K401SocialApp.DataAccess.Abstract;
using K401SocialApp.Entities.Concrete;
using K401SocialApp.Entities.Dtos.UserDtos;
using K401SocialApp.Entities.SharedModels;
using MassTransit;

namespace K401SocialApp.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;
        public UserManager(IUserDal userDal, IMapper mapper, IPublishEndpoint publishEndpoint)
        {
            _userDal = userDal;
            _mapper = mapper;
            _publishEndpoint = publishEndpoint;
        }

        public IResult AddFriend(int userId, int friendId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserProfileDto> GetUserProfil(int userId)
        {
            throw new NotImplementedException();
        }

        public IResult Login(UserLoginDto userLogin)
        {

            var result = BusinessRule.Check(CheckUserEmailAndPassword(userLogin.Email,userLogin.Password));
            var user = _userDal.Get(x => x.Email == userLogin.Email);
            if (!result.Success)
                return new ErrorResult();

            var token = Token.CreateToken(user, "User");

            return new SuccessResult(token);

        }

        public IResult Register(UserRegisterDto userRegister)
        {
            var result = BusinessRule.Check(
                CheckUserEmailIsExist(userRegister.Email),
                CheckUserAge(userRegister.BirtDay)
                );
            if (!result.Success)
                return new ErrorResult();

            var mapToUser = _mapper.Map<User>(userRegister);
            byte[] passwordHash, passwordSalt;
            mapToUser.Avatar = "";
            mapToUser.CoverPhoto = "adas";
            mapToUser.EmailToken = Guid.NewGuid().ToString();
            HashingHelper.HashPassword(userRegister.Password, out passwordHash, out passwordSalt);
            mapToUser.PasswordHash = passwordHash;
            mapToUser.PasswordSalt = passwordSalt;
            mapToUser.TokenEndDate = DateTime.Now.AddMinutes(1);
            _userDal.Add(mapToUser);
            SendEmailConfirmationCommand command = new()
            {
                Email = mapToUser.Email,
                FirstName = mapToUser.FirstName,
                LastName = mapToUser.LastName,
                Token = mapToUser.EmailToken
            };

            _publishEndpoint.Publish<SendEmailConfirmationCommand>(command);
            // sending email

            return new SuccessResult();
        }

        public IResult SendEmail()
        {
            throw new NotImplementedException();
        }

        public IResult VerifyEmail(string email, string token)
        {
            var user = _userDal.Get(x => x.Email == email);
            if (user.EmailToken == token)
            {
                if (DateTime.Compare(user.TokenEndDate, DateTime.Now) < 0)
                {
                    return new ErrorResult();
                }
                user.EmailConfirmed = true;
                _userDal.Update(user);

                return new SuccessResult();
            }
            return new ErrorResult();
        }




        private IResult CheckUserEmailIsExist(string email)
        {
            var user = _userDal.Get(z => z.Email == email);
            if (user is not null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IResult CheckUserAge(DateTime birthday)
        {
            var check = DateTime.Now - birthday;
            if (false)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }


        private IResult CheckUserEmailAndPassword(string email,string password)
        {
            var user = _userDal.Get(x=>x.Email == email);
            if (user is null)
            {
                return new ErrorResult(Messages.Unauthoraized);
            }
            var result = HashingHelper.VerifyPassword(password,user.PasswordHash,user.PasswordSalt);
            if (!result)
            {
                return new ErrorResult(Messages.Unauthoraized);
            }

            return new SuccessResult();
        }

    }
}

