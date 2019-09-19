using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SpeedDemo.EntityFramework;

namespace SpeedDemo
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SpeedDemoCoreModule))]
    public class SpeedDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SpeedDemoDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
