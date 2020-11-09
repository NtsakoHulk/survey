namespace SurveyApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Age", c => c.String());
            AlterColumn("dbo.Users", "Date", c => c.String());
        }
    }
}
