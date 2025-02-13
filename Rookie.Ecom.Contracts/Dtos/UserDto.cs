﻿using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class UserDto
    {
        public Guid? Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public Guid? RoleId { get; set; }
    }
}
