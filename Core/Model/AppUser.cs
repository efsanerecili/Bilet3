﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
  public  class AppUser:IdentityUser
    {
        public string name {  get; set; }
        public string surname { get; set; }
       
    }
}
