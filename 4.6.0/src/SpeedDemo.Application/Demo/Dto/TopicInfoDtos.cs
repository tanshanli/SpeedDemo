using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SpeedDemo.Dtos;
using System;
using System.ComponentModel.DataAnnotations;
namespace SpeedDemo.Demo.Dto
{
    /// <summary>
    /// 分页查询参数
    /// </summary>
    public class GetTopicInfoPageInput : DataTablesPagedAndSortedInputDto
    {
        /// <summary>
        /// 模块Id，为null则查所有模块
        /// </summary>
        public int? ModuleId { get; set; }
    }

    [AutoMap(typeof(TopicInfo))]
    public class TopicInfoDto : EntityDto<long>
    {
        /// <summary>
        /// 模块Id
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 创建人Id
        /// </summary>
        public long? CreatorUserId { get; set; }
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string CreatorUserName { get; set; }
        /// <summary>
        /// 创建人头像
        /// </summary>
        public string CreatorUserIconPath { get; set; }
        /// <summary>
        /// 创建人真实姓名
        /// </summary>
        public string CreatorName { get; set; }
        /// <summary>
        /// 创建人昵称
        /// </summary>
        public string CreatorSurname { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 楼栋号
        /// </summary>
        public string BuildingNo { get; set; }
        /// <summary>
        /// 房门号
        /// </summary>
        public string HouseNum { get; set; }

        /// <summary>
        /// 是否为业主（true：表示用户已经是业主了）
        /// </summary>
        public bool IsHouseOwner { get; set; }
       
        /// <summary>
        /// 是否可以评论
        /// </summary>
        public bool AllowComments { get; set; } = true;
        /// <summary>
        /// 查看数
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 回复数
        /// </summary>
        public int ReplyCount { get; set; }
        /// <summary>
        /// 是否为精华
        /// </summary>
        public bool IsEssence { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsPinned { get; set; } = false;
        /// <summary>
        /// 置顶优先级
        /// </summary>
        public int? PinnedPriority { get; set; }

    }

    [AutoMap(typeof(TopicInfo))]
    public class CreateTopicInfoDto : EntityDto<long>
    {
        /// <summary>
        /// 模块Id
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [Required(ErrorMessage = "标题不能为空")]
        [StringLength(TopicInfo.MaxTitleLength, ErrorMessage = "标题最大长度不能超过100")]
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [Required(ErrorMessage = "内容不能为空")]
        public string Content { get; set; }
        /// <summary>
        /// 是否可以评论
        /// </summary>
        public bool AllowComments { get; set; } = true;
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsPinned { get; set; } = false;
        /// <summary>
        /// 是否为精华
        /// </summary>
        public bool IsEssence { get; set; }
        /// <summary>
        /// 置顶优先级
        /// </summary>
        public int? PinnedPriority { get; set; }

    }

    [AutoMap(typeof(TopicInfo))]
    public class UpdateTopicInfoDto : EntityDto<long>
    {
        /// <summary>
        /// 模块Id
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [StringLength(TopicInfo.MaxTitleLength)]
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 是否可以评论
        /// </summary>
        public bool AllowComments { get; set; } = true;
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsPinned { get; set; } = false;
        /// <summary>
        /// 是否为精华
        /// </summary>
        public bool IsEssence { get; set; }
        /// <summary>
        /// 置顶优先级
        /// </summary>
        public int? PinnedPriority { get; set; }
        /// <summary>
        /// 查看数
        /// </summary>
        public int ViewCount { get; set; }

    }
}
