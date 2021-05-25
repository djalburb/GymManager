﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GymManager.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AplicationUser class
    public class AplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Apellido { get; set; }
    }
}
