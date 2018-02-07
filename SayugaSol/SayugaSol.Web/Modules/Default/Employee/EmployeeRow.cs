
namespace SayugaSol.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[sol].[Employee]"), DisplayName("Employee"), InstanceName("Employee"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Default.Employee")]
    public sealed class EmployeeRow : Row, IIdRow, INameRow
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

        [DisplayName("FullName"), QuickSearch]
        [Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
        [Expression("(T0.FirstName || ' ' || T0.LastName)", Dialect = "Sqlite")]
        public String FullName
        {
            get { return Fields.FullName[this]; }
            set { Fields.FullName[this] = value; }
        }

        [DisplayName("Title"), Size(150)]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Dob"), Column("DOB")]
        public DateTime? Dob
        {
            get { return Fields.Dob[this]; }
            set { Fields.Dob[this] = value; }
        }

        [DisplayName("Hire Date")]
        public DateTime? HireDate
        {
            get { return Fields.HireDate[this]; }
            set { Fields.HireDate[this] = value; }
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

        [DisplayName("Postal Code"), Size(150)]
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

        [DisplayName("Reports To")]
        public Int32? ReportsTo
        {
            get { return Fields.ReportsTo[this]; }
            set { Fields.ReportsTo[this] = value; }
        }

        [DisplayName("Photo"), Size(150), ImageUploadEditor(FilenameFormat = "EmployeeImage/~", CopyToHistory = true)]
        public String Photo
        {
            get { return Fields.Photo[this]; }
            set { Fields.Photo[this] = value; }
        }

        [DisplayName("Photo Path"), Size(150)]
        public String PhotoPath
        {
            get { return Fields.PhotoPath[this]; }
            set { Fields.PhotoPath[this] = value; }
        }

        [DisplayName("Skills"), ForeignKey(typeof(SkillRow)), LeftJoin("skill")]
        [LookupEditor(typeof(SkillRow), Multiple = true)]
        public Int32? SkillId
        {
            get { return Fields.SkillId[this]; }
            set { Fields.SkillId[this] = value; }
        }

        [DisplayName("Skill Name"), Expression("skill.[Name]")]
        public String skillName
        {
            get { return Fields.skillName[this]; }
            set { Fields.skillName[this] = value; }
            
        }

        [DisplayName("Certifications"), ForeignKey(typeof(CertificationRow)), LeftJoin("cert")]
        [LookupEditor(typeof(CertificationRow), Multiple =true)]
        public Int32? CertificationId
        {
            get { return Fields.CertificationId[this]; }
            set { Fields.CertificationId[this] = value; }
        }

        [DisplayName("Certification Name"), Expression("cert.[Name]")]
        public String certName
        {
            get { return Fields.certName[this]; }
            set { Fields.certName[this] = value; }

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

        public EmployeeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField LastName;
            public StringField FirstName;
            public StringField Title;
            public StringField FullName;
            public DateTimeField Dob;
            public DateTimeField HireDate;
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
            public Int32Field ReportsTo;
            public StringField Photo;
            public StringField PhotoPath;
            public Int32Field SkillId;
            public Int32Field CertificationId;

            public StringField skillName;
            public StringField certName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Employee";
            }
        }
    }
}
