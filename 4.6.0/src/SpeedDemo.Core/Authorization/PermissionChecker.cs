using Abp.Authorization;
using SpeedDemo.Authorization.Roles;
using SpeedDemo.Authorization.Users;

namespace SpeedDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
