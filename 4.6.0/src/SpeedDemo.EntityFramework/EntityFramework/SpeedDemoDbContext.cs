using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using SpeedDemo.Authorization.Roles;
using SpeedDemo.Authorization.Users;
using SpeedDemo.Demo;
using SpeedDemo.MultiTenancy;

namespace SpeedDemo.EntityFramework
{
    public class SpeedDemoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<TopicInfo> TopicInfo { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SpeedDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SpeedDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SpeedDemoDbContext since ABP automatically handles it.
         */
        public SpeedDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SpeedDemoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SpeedDemoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
