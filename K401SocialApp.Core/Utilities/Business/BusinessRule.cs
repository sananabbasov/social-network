using System;
using K401SocialApp.Core.Utilities.Results.Abstract;
using K401SocialApp.Core.Utilities.Results.Concrete;

namespace K401SocialApp.Core.Utilities.Business
{
    public class BusinessRule
    {
        public static IResult Check(params IResult[] logics)
        {
            foreach (var resutl in logics)
            {
                if (!resutl.Success)
                {
                    return new ErrorResult();
                }
            }
            return new SuccessResult();
        }
    }
}

