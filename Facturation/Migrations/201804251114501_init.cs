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
                        Annee = c.DateTime(nullable: false),
                        trimestre = c.Int(nullable: false),
                        nIndex = c.Int(nullable: false),
                        pIndex = c.Int(nullable: false),
                        nPayer = c.Double(nullable: false),
                        eau_NPolice = c.Int(),
                        eau_Adresse = c.String(maxLength: 100),
                        eau_Date = c.DateTime(),
                        eau_Tel = c.String(maxLength: 20),
                        eau_NCompteur = c.Int(),
                        eau_Reference = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => new { t.Annee, t.trimestre })
                .ForeignKey("dbo.Eaux", t => new { t.eau_NPolice, t.eau_Adresse, t.eau_Date, t.eau_Tel, t.eau_NCompteur, t.eau_Reference })
                .Index(t => new { t.eau_NPolice, t.eau_Adresse, t.eau_Date, t.eau_Tel, t.eau_NCompteur, t.eau_Reference });
            
            CreateTable(
                "dbo.RelveeElecs",
                c => new
                    {
                        Annee = c.DateTime(nullable: false),
                        trimestre = c.Int(nullable: false),
                        nIndex = c.Int(nullable: false),
                        pIndex = c.Int(nullable: false),
                        nPayer = c.Double(nullable: false),
                        elec_NPolice = c.Int(),
                        elec_Adresse = c.String(maxLength: 100),
                        elec_Date = c.DateTime(),
                        elec_Tel = c.String(maxLength: 20),
                        elec_NCompteur = c.Int(),
                        elec_Reference = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => new { t.Annee, t.trimestre })
                .ForeignKey("dbo.Electricites", t => new { t.elec_NPolice, t.elec_Adresse, t.elec_Date, t.elec_Tel, t.elec_NCompteur, t.elec_Reference })
                .Index(t => new { t.elec_NPolice, t.elec_Adresse, t.elec_Date, t.elec_Tel, t.elec_NCompteur, t.elec_Reference });
            
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
            DropForeignKey("dbo.RelveeElecs", new[] { "elec_NPolice", "elec_Adresse", "elec_Date", "elec_Tel", "elec_NCompteur", "elec_Reference" }, "dbo.Electricites");
            DropForeignKey("dbo.RelveeEaux", new[] { "eau_NPolice", "eau_Adresse", "eau_Date", "eau_Tel", "eau_NCompteur", "eau_Reference" }, "dbo.Eaux");
            DropForeignKey("dbo.Electricites", "TypeElec_id", "dbo.TypeElectricites");
            DropForeignKey("dbo.Electricites", "Etat_id", "dbo.Etats");
            DropForeignKey("dbo.Eaux", "TypeEau_id", "dbo.TypeEaux");
            DropForeignKey("dbo.Eaux", "Etat_id", "dbo.Etats");
            DropIndex("dbo.TeleCommunications", new[] { "TypeTelecom_id" });
            DropIndex("dbo.TeleCommunications", new[] { "Etat_id" });
            DropIndex("dbo.RelveeElecs", new[] { "elec_NPolice", "elec_Adresse", "elec_Date", "elec_Tel", "elec_NCompteur", "elec_Reference" });
            DropIndex("dbo.RelveeEaux", new[] { "eau_NPolice", "eau_Adresse", "eau_Date", "eau_Tel", "eau_NCompteur", "eau_Reference" });
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
