﻿using System;
namespace K401SocialApp.Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}

