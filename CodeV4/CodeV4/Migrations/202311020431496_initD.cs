namespace CodeV4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleDetails",
                c => new
                    {
                        SaleDetailId = c.Long(nullable: false, identity: true),
                        SaleId = c.Long(),
                        ProductName = c.String(maxLength: 50, unicode: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SaleDetailId)
                .ForeignKey("dbo.SaleMasters", t => t.SaleId)
                .Index(t => t.SaleId);
            
            CreateTable(
                "dbo.SaleMasters",
                c => new
                    {
                        SaleId = c.Long(nullable: false, identity: true),
                        CreateDate = c.DateTime(),
                        CustomerName = c.String(maxLength: 50, unicode: false),
                        CustomerAddress = c.String(maxLength: 50, unicode: false),
                        Gender = c.String(maxLength: 10, unicode: false),
                        Photo = c.String(maxLength: 500, unicode: false),
                        ProductType = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.SaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetails", "SaleId", "dbo.SaleMasters");
            DropIndex("dbo.SaleDetails", new[] { "SaleId" });
            DropTable("dbo.SaleMasters");
            DropTable("dbo.SaleDetails");
        }
    }
}
