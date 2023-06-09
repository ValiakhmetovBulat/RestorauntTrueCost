﻿using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Shared.Models
{
    public class UpdateUserDto
    {
        public int RoleId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }

        public static implicit operator UpdateUserDto(User user)
        {
            return new UpdateUserDto
            {
                Name = user.Name,
                Email = user.Email,
                Surname = user.Surname,
                RoleId = user.RoleId,
                Phone = user.Phone,
                Password = user.Password,
            };
        }

        public static implicit operator User(UpdateUserDto user)
        {
            return new User
            {
                Name = user.Name,
                Email = user.Email,
                Surname = user.Surname,
                RoleId = user.RoleId,
                Phone = user.Phone,
                Password = user.Password,
            };
        }
    }


}
