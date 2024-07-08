using Abp.Authorization;
using NishilPort.Authorization.Roles;
using NishilPort.Authorization.Users;

namespace NishilPort.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
