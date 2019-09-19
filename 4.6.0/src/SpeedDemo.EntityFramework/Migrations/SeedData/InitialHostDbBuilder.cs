using SpeedDemo.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SpeedDemo.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SpeedDemoDbContext _context;

        public InitialHostDbBuilder(SpeedDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
