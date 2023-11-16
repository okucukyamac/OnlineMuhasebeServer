﻿using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Domain.AppEntities
{
    public class UserAndCompany:Entity
    {
        [ForeignKey("AppUser")]
        public Guid AppUserId { get; set; }
        public AppUser  AppUser{ get; set; }

        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
