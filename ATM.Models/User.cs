using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public enum Gender
    {
        Male,
        Female,
    }
    public class User:IdentityUser
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }

    }
}
