using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using SpeedDemo.Demo.Dto;
using SpeedDemo.MultiTenancy;
using System.Collections.Generic;
using System.Data.Entity;
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
        ITestRepository testRepository;
        public DemoAppService(
            ITestRepository test1Repository,
            IRepository<TopicInfo, long> topicInfoRepository)
            : base(topicInfoRepository)
        {
            this.testRepository = test1Repository;
        }
        public void Demo()
        {
            Stopwatch sw = new Stopwatch();
            long totalTime = 0;

            //simple EF(Do not use the encapsulation of EF in ABP)
            sw.Start();
            var simpleEfResult = testRepository.GetAll();
            sw.Stop();
            totalTime = sw.ElapsedMilliseconds;
            Debug.WriteLine($"simpleEfResult count:{simpleEfResult.Count},time:{totalTime}");

            //abp sql query (Database.SqlQuery)
            sw.Reset();
            sw.Start();
            var abpSqlResult = testRepository.GetSqlAll();
            sw.Stop();
            totalTime = sw.ElapsedMilliseconds;
            Debug.WriteLine($"abpSqlResult count:{abpSqlResult.Count},time:{totalTime}");

            //abp linq query
            sw.Reset();
            sw.Start();
            var abpLinqResult = Repository.GetAll().AsNoTracking().ToList();
            sw.Stop();
            totalTime = sw.ElapsedMilliseconds;
            Debug.WriteLine($"abpLinqResult count:{abpLinqResult.Count},time:{totalTime}");

        }
    }
}
