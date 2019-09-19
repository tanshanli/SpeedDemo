using System.Collections.Generic;
using SpeedDemo.Roles.Dto;
using SpeedDemo.Users.Dto;

namespace SpeedDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}