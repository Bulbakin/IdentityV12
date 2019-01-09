using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityV12.Models
{
    
    public class ApplicationRole : IdentityRole
    {

        public enum Role
        {
            Admin, Role1, Role2
        }
    }
}

