using Abp.EntityFramework;
using SpeedDemo.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDemo.EntityFramework.Repositories
{
    public class TestRepository : ITestRepository
    {
        IDbContextProvider<SpeedDemoDbContext> dbContextProvider;
        public TestRepository(IDbContextProvider<SpeedDemoDbContext> dbContextProvider)
        {
            this.dbContextProvider = dbContextProvider;
        }

        public List<TopicInfo> GetAll()
        {
            using (var context = new SimpleEfDbContext())
            {
                return context.TopicInfo.ToList();
            }
        }

        public List<TopicInfo> GetSqlAll()
        {
            return dbContextProvider.GetDbContext()
                  .Database.SqlQuery<TopicInfo>("select * from TopicInfo").ToList();
        }
    }
}
