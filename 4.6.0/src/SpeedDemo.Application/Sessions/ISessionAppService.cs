using System.Threading.Tasks;
using Abp.Application.Services;
using SpeedDemo.Sessions.Dto;

namespace SpeedDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
