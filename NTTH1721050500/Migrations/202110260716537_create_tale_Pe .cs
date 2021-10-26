namespace NTTH1721050500.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_tale_Pe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 20),
                        PersonName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
