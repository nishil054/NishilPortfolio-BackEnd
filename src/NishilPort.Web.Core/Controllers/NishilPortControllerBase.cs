using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NishilPort.Controllers
{
    public abstract class NishilPortControllerBase: AbpController
    {
        protected NishilPortControllerBase()
        {
            LocalizationSourceName = NishilPortConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
