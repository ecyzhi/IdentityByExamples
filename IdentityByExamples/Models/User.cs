using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityByExamples.Models
{
    public class User : IdentityUser //Inherits from IdentityUser provided by ASP.NET Identity, defines additional properties
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
