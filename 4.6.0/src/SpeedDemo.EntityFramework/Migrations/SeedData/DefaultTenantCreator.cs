using System.Linq;
using SpeedDemo.EntityFramework;
using SpeedDemo.MultiTenancy;

namespace SpeedDemo.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SpeedDemoDbContext _context;

        public DefaultTenantCreator(SpeedDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
