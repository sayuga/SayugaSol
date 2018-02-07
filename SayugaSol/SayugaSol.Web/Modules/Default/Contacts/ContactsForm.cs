
namespace SayugaSol.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Contacts")]
    [BasedOnRow(typeof(Entities.ContactsRow))]
    public class ContactsForm
    {
        public String CompanyName { get; set; }
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
    }
}