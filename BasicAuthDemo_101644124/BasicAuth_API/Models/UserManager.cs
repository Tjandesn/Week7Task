using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace BasicAuth_API.Models
{
    public class UserManager
    {
        private BasicAuth_DBEntities _Context;

        public UserManager()
        {
            _Context = new BasicAuth_DBEntities();
        }

        public bool ValidateUser(string userName, string password)
        {
            var result = _Context.UserMasters.SingleOrDefault(x => x.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
            && x.Password == password);

            return result != null ? true : false;
        }
    }
}