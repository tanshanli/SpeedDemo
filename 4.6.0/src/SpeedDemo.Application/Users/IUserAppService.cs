using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SpeedDemo.Roles.Dto;
using SpeedDemo.Users.Dto;

namespace SpeedDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}