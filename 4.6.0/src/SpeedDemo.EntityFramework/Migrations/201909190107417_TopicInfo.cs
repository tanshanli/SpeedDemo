namespace SpeedDemo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class TopicInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TopicInfo",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TenantId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        AllowComments = c.Boolean(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        IsEssence = c.Boolean(nullable: false),
                        IsPinned = c.Boolean(nullable: false),
                        PinnedPriority = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_TopicInfo_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_TopicInfo_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.TenantId)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TopicInfo", new[] { "IsDeleted" });
            DropIndex("dbo.TopicInfo", new[] { "TenantId" });
            DropTable("dbo.TopicInfo",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_TopicInfo_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                    { "DynamicFilter_TopicInfo_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
