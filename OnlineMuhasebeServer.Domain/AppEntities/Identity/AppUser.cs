﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Domain.AppEntities.Identity
{
    public sealed class AppUser:IdentityUser<Guid>
    {
        public Guid CompanyId { get; set; }
    }
}
