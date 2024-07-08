using System.Threading.Tasks;
using Abp.Application.Services;
using NishilPort.Sessions.Dto;

namespace NishilPort.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
