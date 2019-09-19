using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDemo.Demo
{
    [Table("TopicInfo")]
    public class TopicInfo : FullAuditedEntity<long>, IMustHaveTenant
    {
        public const int MaxTitleLength = 100;

        public int TenantId { get; set; }

        public int ModuleId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool AllowComments { get; set; } = true;

        public int ViewCount { get; set; }

        public bool IsEssence { get; set; }

        public bool IsPinned { get; set; } = false;

        public int? PinnedPriority { get; set; }
    }
}
