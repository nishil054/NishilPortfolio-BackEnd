using System.Threading.Tasks;
using Abp.Application.Services;
using NishilPort.Authorization.Accounts.Dto;

namespace NishilPort.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
