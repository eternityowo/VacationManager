﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VacationManager.WEB.Models
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public IEnumerable<RoleViewModel> Roles { get; set; }
    }
}