namespace WcfService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "CustomerCode", c => c.String(nullable: false));
            AddColumn("dbo.Accounts", "SercurityCode", c => c.String(nullable: false));
            DropColumn("dbo.Accounts", "Code");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "Code", c => c.String(nullable: false));
            DropColumn("dbo.Accounts", "SercurityCode");
            DropColumn("dbo.Accounts", "CustomerCode");
        }
    }
}
