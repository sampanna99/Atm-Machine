namespace AutomatedTellerMaching.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Idontknow : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "Balance", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.CheckingAccounts", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
