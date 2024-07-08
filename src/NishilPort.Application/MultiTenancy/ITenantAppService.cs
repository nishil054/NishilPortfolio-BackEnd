using Abp.Application.Services;
using NishilPort.MultiTenancy.Dto;

namespace NishilPort.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

