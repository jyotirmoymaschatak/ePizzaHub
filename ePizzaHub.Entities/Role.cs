﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizzaHub.Entities
{
    public class Role : IdentityRole<int>
    {
        // TO DO:
        public string Description { get; set; }
    }
}
