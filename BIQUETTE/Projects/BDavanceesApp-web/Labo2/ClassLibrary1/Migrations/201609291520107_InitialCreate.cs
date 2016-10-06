namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        AccountBalance = c.Double(nullable: false),
                        AdresseLine1 = c.String(),
                        AdresseLine2 = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Email = c.String(),
                        Name = c.String(),
                        PostCode = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
