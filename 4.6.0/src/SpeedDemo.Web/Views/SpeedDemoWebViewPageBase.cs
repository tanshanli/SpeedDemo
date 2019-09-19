using Abp.Web.Mvc.Views;

namespace SpeedDemo.Web.Views
{
    public abstract class SpeedDemoWebViewPageBase : SpeedDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class SpeedDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SpeedDemoWebViewPageBase()
        {
            LocalizationSourceName = SpeedDemoConsts.LocalizationSourceName;
        }
    }
}