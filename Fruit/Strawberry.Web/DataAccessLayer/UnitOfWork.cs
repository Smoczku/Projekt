using Strawberry.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strawberry.Web.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<UserProfile> userRepository;
        private IRepository<Group> groupRepository;
        private IRepository<Assignment> assignmentRepository;
        private IRepository<MyTask> taskRepository;

        private MyContext context;


        public UnitOfWork(MyContext context)
        {
            this.context = context;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public IRepository<UserProfile> UserRepository
        {
            get 
            {
                if (this.userRepository == null)
                    this.userRepository = new Repository<UserProfile>(context);
                return userRepository;
            }
        }

        public IRepository<Group> GroupRepository
        {
            get
            {
                if (this.groupRepository == null)
                    this.groupRepository = new Repository<Group>(context);
                return groupRepository;
            }
        }

        public IRepository<Assignment> AssignmentRepository
        {
            get
            {
                if (this.assignmentRepository == null)
                    this.assignmentRepository = new Repository<Assignment>(context);
                return assignmentRepository;
            }
        }

        public IRepository<MyTask> TaskRepository
        {
            get
            {
                if (this.taskRepository == null)
                    this.taskRepository = new Repository<MyTask>(context);
                return taskRepository;
            }
        }
    }
}