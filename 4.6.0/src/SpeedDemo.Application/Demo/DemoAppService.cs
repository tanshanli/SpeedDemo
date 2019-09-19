using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using SpeedDemo.Demo.Dto;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace SpeedDemo.Demo
{
    public interface IDemoAppService : IAsyncCrudAppService<TopicInfoDto, long, PagedResultRequestDto, CreateTopicInfoDto, UpdateTopicInfoDto>
    {
        void Demo();
    }

    public class DemoAppService : AsyncCrudAppService<TopicInfo, TopicInfoDto, long, PagedResultRequestDto, CreateTopicInfoDto, UpdateTopicInfoDto>
        , IDemoAppService
    {
        public DemoAppService(IRepository<TopicInfo,long> topicInfoRepository)
            : base(topicInfoRepository)
        {
        }
        public void Demo()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var list = Repository.GetAll().ToList();
            sw.Stop();
            long totalTime = sw.ElapsedMilliseconds;
            Debug.WriteLine($"count:{list.Count},time:{totalTime}");

            sw.Reset();
            sw.Start();
            var list2 = Repository.GetAll().ToList();
            sw.Stop();
            totalTime = sw.ElapsedMilliseconds;
            Debug.WriteLine($"count:{list2.Count},time:{totalTime}");
            /* 
             * output
             * 
             count:40001,time:19941
             count:40001,time:106

            * test second output

            count:40001,time:34677
            count:40001,time:188
             */
        }
    }
}
