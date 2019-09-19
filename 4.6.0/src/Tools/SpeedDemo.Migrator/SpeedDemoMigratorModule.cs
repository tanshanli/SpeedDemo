using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SpeedDemo.EntityFramework;

namespace SpeedDemo.Migrator
{
    [DependsOn(typeof(SpeedDemoDataModule))]
    public class SpeedDemoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SpeedDemoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}