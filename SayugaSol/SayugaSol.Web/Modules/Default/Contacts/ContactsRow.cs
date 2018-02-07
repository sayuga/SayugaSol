
namespace SayugaSol.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[sol].[Contacts]"), DisplayName("Contacts"), InstanceName("Contacts"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ContactsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Last Name"), Size(150), QuickSearch]
        public String LastName
        {
            get { return Fields.LastName[this]; }
            set { Fields.LastName[this] = value; }
        }

        [DisplayName("First Name"), Size(150)]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Title"), Size(150)]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Address"), Size(150)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("City"), Size(150)]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        [DisplayName("Region"), Size(150)]
        public String Region
        {
            get { return Fields.Region[this]; }
            set { Fields.Region[this] = value; }
        }

        [DisplayName("Postal Code"), Column("Postal Code"), Size(150)]
        public String PostalCode
        {
            get { return Fields.PostalCode[this]; }
            set { Fields.PostalCode[this] = value; }
        }

        [DisplayName("Country"), Size(150)]
        public String Country
        {
            get { return Fields.Country[this]; }
            set { Fields.Country[this] = value; }
        }

        [DisplayName("Email"), Size(250), EmailEditor]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Phone1"), Size(150), PhoneEditor]
        public String Phone1
        {
            get { return Fields.Phone1[this]; }
            set { Fields.Phone1[this] = value; }
        }

        [DisplayName("Phone1 Type")]
        public Int16? Phone1Type
        {
            get { return Fields.Phone1Type[this]; }
            set { Fields.Phone1Type[this] = value; }
        }

        [DisplayName("Phone2"), Size(150), PhoneEditor]
        public String Phone2
        {
            get { return Fields.Phone2[this]; }
            set { Fields.Phone2[this] = value; }
        }

        [DisplayName("Phone2 Type")]
        public Int16? Phone2Type
        {
            get { return Fields.Phone2Type[this]; }
            set { Fields.Phone2Type[this] = value; }
        }

        [DisplayName("Notes"), Size(150), TextAreaEditor(Rows =3)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("Company Name"), Size(250)]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LastName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ContactsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField LastName;
            public StringField FirstName;
            public StringField Title;
            public StringField Address;
            public StringField City;
            public StringField Region;
            public StringField PostalCode;
            public StringField Country;
            public StringField Email;
            public StringField Phone1;
            public Int16Field Phone1Type;
            public StringField Phone2;
            public Int16Field Phone2Type;
            public StringField Notes;
            public StringField CompanyName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Contacts";
            }
        }
    }
}
