﻿using Microsoft.Build.Framework;

namespace kapraMarket.web.Models
{
    public class Permission
    {
        public Guid Id { get; set; }
        [Required]
        public int RoleId { get; set; }
        public IList<RoleClaimsViewModel> RoleClaims { get; set; }
    }
    public class RoleClaimsViewModel
    {
        [Required]
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}
