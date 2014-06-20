using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Strawberry.Web.DataAccessLayer;
using Strawberry.Web.Models;

namespace Strawberry.Web.BuisnessLogic
{
    public class UserService : IUserService
    {
        private IRepository<UserProfile> _userRepository;
 
        public UserService(IRepository<UserProfile> repository)
        {
            this._userRepository = repository;
        }

        public IEnumerable<UserProfile> All()
        {
            return _userRepository.All;
        }

        public UserProfile Find(int id)
        {
            return _userRepository.Find(id);
        }
    }

}