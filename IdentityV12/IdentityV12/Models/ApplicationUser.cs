﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityV12.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }
    }
}
