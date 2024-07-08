using System.Threading.Tasks;
using NishilPort.Configuration.Dto;

namespace NishilPort.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
