using System;
using K401SocialApp.Core.Utilities.Results.Abstract;

namespace K401SocialApp.Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>, IDataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }

    }
}

