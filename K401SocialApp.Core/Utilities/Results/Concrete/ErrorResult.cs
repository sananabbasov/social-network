using System;
using K401SocialApp.Core.Utilities.Results.Abstract;

namespace K401SocialApp.Core.Utilities.Results.Concrete
{
    public class ErrorResult : Result, IResult
    {
        public ErrorResult(string message) : base(false, message)
        {
        }
        public ErrorResult() : base(false)
        {
        }
    }
}
