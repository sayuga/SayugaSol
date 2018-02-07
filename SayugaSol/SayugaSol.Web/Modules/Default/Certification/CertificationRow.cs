
namespace SayugaSol.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[sol].[Certification]"), DisplayName("Certification"), InstanceName("Certification"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Default.Certification")]
    public sealed class CertificationRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Name"), Size(255), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Description"), Size(255), TextAreaEditor(Rows =3)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Date Acquired")]
        public DateTime? DateAcquired
        {
            get { return Fields.DateAcquired[this]; }
            set { Fields.DateAcquired[this] = value; }
        }

        [DisplayName("Expiration Date")]
        public DateTime? ExpirationDate
        {
            get { return Fields.ExpirationDate[this]; }
            set { Fields.ExpirationDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CertificationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Description;
            public DateTimeField DateAcquired;
            public DateTimeField ExpirationDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Certification";
            }
        }
    }
}
