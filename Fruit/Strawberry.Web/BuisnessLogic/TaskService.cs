using Strawberry.Web.DataAccessLayer;
using Strawberry.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strawberry.Web.BuisnessLogic
{
    public class TaskService : ITaskService
    {
        private IRepository<MyTask> _taskRepository;

        public TaskService(IRepository<MyTask> repository)
        {
            this._taskRepository = repository;
        }
    }
}