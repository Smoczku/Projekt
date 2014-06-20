using Strawberry.Web.Models;
using System;
using System.Data.Entity;
namespace Strawberry.Web.DataAccessLayer
{
    public interface IMyContext
    {
        IDbSet<Assignment> Assignments { get; set; }
        IDbSet<Group> Groups { get; set; }
        IDbSet<MyTask> Tasks { get; set; }
        IDbSet<UserProfile> UserProfiles { get; set; }
    }
}
