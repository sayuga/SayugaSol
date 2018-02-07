
namespace SayugaSol.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Contacts")]
    [BasedOnRow(typeof(Entities.ContactsRow))]
    public class ContactsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String Title { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        public String Email { get; set; }
        public String Phone1 { get; set; }
        public Int16 Phone1Type { get; set; }
        public String Phone2 { get; set; }
        public Int16 Phone2Type { get; set; }
        public String Notes { get; set; }
        public String CompanyName { get; set; }
    }
}