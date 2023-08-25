using System;
using K401SocialApp.Core.Utilities.Results.Abstract;

namespace K401SocialApp.Core.Utilities.Results.Concrete
{

    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}

