using SpeedDemo.Demo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDemo.EntityFramework
{
    public class SimpleEfDbContext : DbContext
    {
        public SimpleEfDbContext()
            : base("name=SpeedDemoEntities")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public virtual DbSet<TopicInfo> TopicInfo { get; set; }
    }
}
