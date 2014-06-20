using Strawberry.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strawberry.Web.DataAccessLayer
{
    public interface IUnitOfWork
    {
        IRepository<UserProfile> UserRepository { get; }
        IRepository<Group> GroupRepository { get; }
        IRepository<Assignment> AssignmentRepository { get; }
        IRepository<MyTask> TaskRepository { get; }         

        void SaveChanges();
    }
}