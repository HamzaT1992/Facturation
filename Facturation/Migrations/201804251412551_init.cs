namespace Facturation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eaux",
                c => new
                    {
                        NPolice = c.Int(nullable: false),
                        Adresse = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                        Tel = c.String(nullable: false, maxLength: 20),
                        NCompteur = c.Int(nullable: false),
                        Reference = c.String(nullable: false, maxLength: 15),
                        Annee = c.Short(nullable: false),
                        Etat_id = c.Int(),
                        TypeEau_id = c.Int(),
                    })
                .PrimaryKey(t => new { t.NPolice, t.Adresse, t.Date, t.Tel, t.NCompteur, t.Reference })
                .ForeignKey("dbo.Etats", t => t.Etat_id)
                .ForeignKey("dbo.TypeEaux", t => t.TypeEau_id)
                .Index(t => t.Etat_id)
                .Index(t => t.TypeEau_id);
            
            CreateTable(
                "dbo.Etats",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NomEtat = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TypeEaux",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NomTypeEau = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Electricites",
                c => new
                    {
                        NPolice = c.Int(nullable: false),
                        Adresse = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                        Tel = c.String(nullable: false, maxLength: 20),
                        NCompteur = c.Int(nullable: false),
                        Reference = c.String(nullable: false, maxLength: 15),
                        Annee = c.Short(nullable: false),
                        Etat_id = c.Int(),
                        TypeElec_id = c.Int(),
                    })
                .PrimaryKey(t => new { t.NPolice, t.Adresse, t.Date, t.Tel, t.NCompteur, t.Reference })
                .ForeignKey("dbo.Etats", t => t.Etat_id)
                .ForeignKey("dbo.TypeElectricites", t => t.TypeElec_id)
                .Index(t => t.Etat_id)
                .Index(t => t.TypeElec_id);
            
            CreateTable(
                "dbo.TypeElectricites",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NomTypeElec = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RelveeEaux",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Annee = c.DateTime(nullable: false),
                        Trimestre = c.Int(nullable: false),
                        NIndex = c.Int(nullable: false),
                        PIndex = c.Int(nullable: false),
                        NPayer = c.Double(nullable: false),
                        Eau_NPolice = c.Int(),
                        Eau_Adresse = c.String(maxLength: 100),
                        Eau_Date = c.DateTime(),
                        Eau_Tel = c.String(maxLength: 20),
                        Eau_NCompteur = c.Int(),
                        Eau_Reference = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => new { t.Id, t.Annee, t.Trimestre })
                .ForeignKey("dbo.Eaux", t => new { t.Eau_NPolice, t.Eau_Adresse, t.Eau_Date, t.Eau_Tel, t.Eau_NCompteur, t.Eau_Reference })
                .Index(t => new { t.Eau_NPolice, t.Eau_Adresse, t.Eau_Date, t.Eau_Tel, t.Eau_NCompteur, t.Eau_Reference });
            
            CreateTable(
                "dbo.RelveeElecs",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Annee = c.DateTime(nullable: false),
                        Trimestre = c.Int(nullable: false),
                        NIndex = c.Int(nullable: false),
                        PIndex = c.Int(nullable: false),
                        NPayer = c.Double(nullable: false),
                        Elec_NPolice = c.Int(),
                        Elec_Adresse = c.String(maxLength: 100),
                        Elec_Date = c.DateTime(),
                        Elec_Tel = c.String(maxLength: 20),
                        Elec_NCompteur = c.Int(),
                        Elec_Reference = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => new { t.Id, t.Annee, t.Trimestre })
                .ForeignKey("dbo.Electricites", t => new { t.Elec_NPolice, t.Elec_Adresse, t.Elec_Date, t.Elec_Tel, t.Elec_NCompteur, t.Elec_Reference })
                .Index(t => new { t.Elec_NPolice, t.Elec_Adresse, t.Elec_Date, t.Elec_Tel, t.Elec_NCompteur, t.Elec_Reference });
            
            CreateTable(
                "dbo.TeleCommunications",
                c => new
                    {
                        NPolice = c.Int(nullable: false),
                        Adresse = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                        Tel = c.String(nullable: false, maxLength: 20),
                        MD = c.String(nullable: false, maxLength: 20),
                        Forfait = c.Int(nullable: false),
                        Montant = c.Double(nullable: false),
                        Etat_id = c.Int(),
                        TypeTelecom_id = c.Int(),
                    })
                .PrimaryKey(t => new { t.NPolice, t.Adresse, t.Date, t.Tel, t.MD })
                .ForeignKey("dbo.Etats", t => t.Etat_id)
                .ForeignKey("dbo.TypeTelecommunications", t => t.TypeTelecom_id)
                .Index(t => t.Etat_id)
                .Index(t => t.TypeTelecom_id);
            
            CreateTable(
                "dbo.TypeTelecommunications",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NomTypeTelecommunication = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeleCommunications", "TypeTelecom_id", "dbo.TypeTelecommunications");
            DropForeignKey("dbo.TeleCommunications", "Etat_id", "dbo.Etats");
            DropForeignKey("dbo.RelveeElecs", new[] { "Elec_NPolice", "Elec_Adresse", "Elec_Date", "Elec_Tel", "Elec_NCompteur", "Elec_Reference" }, "dbo.Electricites");
            DropForeignKey("dbo.RelveeEaux", new[] { "Eau_NPolice", "Eau_Adresse", "Eau_Date", "Eau_Tel", "Eau_NCompteur", "Eau_Reference" }, "dbo.Eaux");
            DropForeignKey("dbo.Electricites", "TypeElec_id", "dbo.TypeElectricites");
            DropForeignKey("dbo.Electricites", "Etat_id", "dbo.Etats");
            DropForeignKey("dbo.Eaux", "TypeEau_id", "dbo.TypeEaux");
            DropForeignKey("dbo.Eaux", "Etat_id", "dbo.Etats");
            DropIndex("dbo.TeleCommunications", new[] { "TypeTelecom_id" });
            DropIndex("dbo.TeleCommunications", new[] { "Etat_id" });
            DropIndex("dbo.RelveeElecs", new[] { "Elec_NPolice", "Elec_Adresse", "Elec_Date", "Elec_Tel", "Elec_NCompteur", "Elec_Reference" });
            DropIndex("dbo.RelveeEaux", new[] { "Eau_NPolice", "Eau_Adresse", "Eau_Date", "Eau_Tel", "Eau_NCompteur", "Eau_Reference" });
            DropIndex("dbo.Electricites", new[] { "TypeElec_id" });
            DropIndex("dbo.Electricites", new[] { "Etat_id" });
            DropIndex("dbo.Eaux", new[] { "TypeEau_id" });
            DropIndex("dbo.Eaux", new[] { "Etat_id" });
            DropTable("dbo.TypeTelecommunications");
            DropTable("dbo.TeleCommunications");
            DropTable("dbo.RelveeElecs");
            DropTable("dbo.RelveeEaux");
            DropTable("dbo.TypeElectricites");
            DropTable("dbo.Electricites");
            DropTable("dbo.TypeEaux");
            DropTable("dbo.Etats");
            DropTable("dbo.Eaux");
        }
    }
}
