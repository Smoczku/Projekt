using Strawberry.Web.DataAccessLayer;
using Strawberry.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strawberry.Web.BuisnessLogic
{
    public class AssignmentService : IAssignmentService
    {
        private IRepository<Assignment> _assignmentRepository;

        public AssignmentService(IRepository<Assignment> repository)
        {
            this._assignmentRepository = repository;
        }
    }
}