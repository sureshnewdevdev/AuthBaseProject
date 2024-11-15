using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationApp.Models
{
  
        public class User
        {
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PasswordHash { get; set; }
            public int RoleId { get; set; }
            public virtual Role Role { get; set; }
        }

        public class Role    
        {
            public int RoleId { get; set; }
            public string RoleName { get; set; }
        }

 
}