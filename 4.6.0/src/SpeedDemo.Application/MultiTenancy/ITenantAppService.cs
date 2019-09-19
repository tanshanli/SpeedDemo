using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SpeedDemo.MultiTenancy.Dto;

namespace SpeedDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
