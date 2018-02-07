using FluentMigrator;
using System;

namespace SayugaSol.Migrations.DefaultDB
{

    [Migration(20170804000001)]
    public class DefaultDB_20170804_000001 : AutoReversingMigration
    {
        public override void Up()
        {
            string schema = "sol";
            Create.Schema(schema);

            Create.Table("Employee").InSchema(schema)
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("LastName").AsString(150).Nullable()
                .WithColumn("FirstName").AsString(150).Nullable()
                .WithColumn("Title").AsString(150).Nullable()
                .WithColumn("DOB").AsDateTime().Nullable()
                .WithColumn("HireDate").AsDateTime().Nullable()
                .WithColumn("Address").AsString(150).Nullable()
                .WithColumn("City").AsString(150).Nullable()
                .WithColumn("Region").AsString(150).Nullable()
                .WithColumn("Postal Code").AsString(150).Nullable()
                .WithColumn("Country").AsString(150).Nullable()
                .WithColumn("Email").AsString(250).Nullable()
                .WithColumn("Phone1").AsString(150).Nullable()
                .WithColumn("Phone1Type").AsInt16().Nullable()
                .WithColumn("Phone2").AsString(150).Nullable()
                .WithColumn("Phone2Type").AsInt16().Nullable()
                .WithColumn("Notes").AsString(150).Nullable()
                .WithColumn("ReportsTo").AsInt32().Nullable()
                .WithColumn("Photo").AsString(150).Nullable()
                .WithColumn("PhotoPath").AsString(150).Nullable()
                .WithColumn("SkillId").AsInt32().Nullable()
                .WithColumn("CertificationId").AsInt32().Nullable()
                ;

            Create.Table("Skill").InSchema(schema)
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(150).NotNullable()
                .WithColumn("Description").AsString().Nullable()
                ;

            Create.Table("Certification").InSchema(schema)
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString().Nullable()
                .WithColumn("DateAcquired").AsDateTime().Nullable()
                .WithColumn("ExpirationDate").AsDateTime().Nullable()
                ;

            Create.Table("Contacts").InSchema(schema)
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("LastName").AsString(150).Nullable()
                .WithColumn("FirstName").AsString(150).Nullable()
                .WithColumn("Title").AsString(150).Nullable()                
                .WithColumn("Address").AsString(150).Nullable()
                .WithColumn("City").AsString(150).Nullable()
                .WithColumn("Region").AsString(150).Nullable()
                .WithColumn("Postal Code").AsString(150).Nullable()
                .WithColumn("Country").AsString(150).Nullable()
                .WithColumn("Email").AsString(250).Nullable()
                .WithColumn("Phone1").AsString(150).Nullable()
                .WithColumn("Phone1Type").AsInt16().Nullable()
                .WithColumn("Phone2").AsString(150).Nullable()
                .WithColumn("Phone2Type").AsInt16().Nullable()
                .WithColumn("Notes").AsString(150).Nullable()
                .WithColumn("CompanyName").AsString(250).Nullable()
                ;
        }
    }
}

