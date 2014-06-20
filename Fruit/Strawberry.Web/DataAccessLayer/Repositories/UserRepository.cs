using Strawberry.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strawberry.Web.DataAccessLayer.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(IMyContext context)
            : base(context)
        { }
    }
}