namespace CafeControl.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuAdi = c.String(maxLength: 50, unicode: false),
                        Aciklama = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        UrunKodu = c.String(maxLength: 20, unicode: false),
                        UrunAdi = c.String(),
                        BirimFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BirimFiyati2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "MenuId", "dbo.Menu");
            DropIndex("dbo.Urun", new[] { "MenuId" });
            DropTable("dbo.Urun");
            DropTable("dbo.Menu");
        }
    }
}
