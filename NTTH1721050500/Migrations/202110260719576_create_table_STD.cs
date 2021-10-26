namespace NTTH1721050500.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_STD : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "University", c => c.String(maxLength: 50));
            AddColumn("dbo.People", "Address", c => c.String(maxLength: 50));
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "Address");
            DropColumn("dbo.People", "University");
        }
    }
}
