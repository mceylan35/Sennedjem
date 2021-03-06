﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class PgGroupDal : EfEntityRepositoryBase<Group, ProjectDbContext>, IGroupDal
    {
        public PgGroupDal(ProjectDbContext context) : base(context)
        {
        }
    }
}
