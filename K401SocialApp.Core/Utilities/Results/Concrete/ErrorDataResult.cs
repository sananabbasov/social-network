using System;
using K401SocialApp.Core.Utilities.Results.Abstract;

namespace K401SocialApp.Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>, IDataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }
        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}

