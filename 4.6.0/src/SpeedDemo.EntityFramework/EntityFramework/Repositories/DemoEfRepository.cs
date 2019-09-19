using SpeedDemo.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDemo.EntityFramework.Repositories
{
    public class DemoEfRepository : IDemoEfRepository
    {
        public List<Demo.TopicInfo> GetAll()
        {
            using (var context = new SpeedDemoEntities())
            {
                return context.TopicInfo.ToList();
            }
        }
    }
}
