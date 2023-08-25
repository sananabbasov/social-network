using System;
using K401SocialApp.Core.Utilities.Results.Abstract;

namespace K401SocialApp.Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}

