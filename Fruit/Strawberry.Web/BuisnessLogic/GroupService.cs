using Strawberry.Web.DataAccessLayer;
using Strawberry.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strawberry.Web.BuisnessLogic
{
    public class GroupService : IGroupService
    {
        private IRepository<Group> _groupRepository;

        public GroupService(IRepository<Group> repository)
        {
            this._groupRepository = repository;
        }
    }
}