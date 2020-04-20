using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace testprojectaspnetcore3_1.Data
{
    public class Customer:IdentityUser
    {
        public string CustomerName { get; set; }
        public string CustomerFamily { get; set; }

    }
}
