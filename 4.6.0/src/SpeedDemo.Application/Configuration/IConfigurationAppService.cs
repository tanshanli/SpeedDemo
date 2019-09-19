using System.Threading.Tasks;
using Abp.Application.Services;
using SpeedDemo.Configuration.Dto;

namespace SpeedDemo.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}