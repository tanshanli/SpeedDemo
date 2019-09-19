using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using SpeedDemo.Demo.Dto;
using SpeedDemo.MultiTenancy;
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
        private IDemoEfRepository demoEfRepository;

        public DemoAppService(IDemoEfRepository demoEfRepository,
            IRepository<TopicInfo, long> topicInfoRepository)
            : base(topicInfoRepository)
        {
            this.demoEfRepository = demoEfRepository;
        }
        public void Demo()
        {
            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            var list2 = demoEfRepository.GetAll();
            sw.Stop();
            var totalTime = sw.ElapsedMilliseconds;
            Debug.WriteLine($"count:{list2.Count},time:{totalTime}");

            sw.Reset();
            sw.Start();
            var list = Repository.GetAll().ToList();
            sw.Stop();
            totalTime = sw.ElapsedMilliseconds;
            Debug.WriteLine($"count:{list.Count},time:{totalTime}");

        }
    }
}
