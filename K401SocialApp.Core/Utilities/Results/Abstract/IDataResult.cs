using System;
namespace K401SocialApp.Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; }
    }
}

