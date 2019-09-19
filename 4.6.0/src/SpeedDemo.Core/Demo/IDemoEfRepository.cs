using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDemo.Demo
{
    public interface IDemoEfRepository : IRepository
    {
        List<TopicInfo> GetAll();
    }
}
