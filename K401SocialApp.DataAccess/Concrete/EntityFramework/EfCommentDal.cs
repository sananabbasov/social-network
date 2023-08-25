﻿using System;
using K401SocialApp.Core.DataAccess.EntityFramework;
using K401SocialApp.DataAccess.Abstract;
using K401SocialApp.Entities.Concrete;

namespace K401SocialApp.DataAccess.Concrete.EntityFramework
{
	public class EfCommentDal : EfRepositoryBase<Comment,AppDbContext>, ICommentDal
	{
	}
}

