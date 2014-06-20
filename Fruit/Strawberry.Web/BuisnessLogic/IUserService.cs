using Strawberry.Web.Models;
using System;
using System.Collections.Generic;

namespace Strawberry.Web.BuisnessLogic
{
    public interface IUserService
    {
        IEnumerable<UserProfile> All();
        UserProfile Find(int id);
    }
}
