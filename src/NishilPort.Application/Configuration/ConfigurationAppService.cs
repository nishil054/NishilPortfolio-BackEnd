using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NishilPort.Configuration.Dto;

namespace NishilPort.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NishilPortAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
