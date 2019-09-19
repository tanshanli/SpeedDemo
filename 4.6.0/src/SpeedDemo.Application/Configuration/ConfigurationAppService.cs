﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SpeedDemo.Configuration.Dto;

namespace SpeedDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SpeedDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
