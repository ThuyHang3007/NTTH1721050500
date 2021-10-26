namespace NTTH1721050500.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Lec : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Faculty", c => c.String(maxLength: 50));
            AddColumn("dbo.People", "Department", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Department");
            DropColumn("dbo.People", "Faculty");
        }
    }
}
