
namespace SayugaSol.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Employee")]
    [BasedOnRow(typeof(Entities.EmployeeRow))]
    public class EmployeeForm
    {
        public String Photo { get; set; }
        public String PhotoPath { get; set; }
        public Int32 ReportsTo { get; set; }
        [Category("Basic Information"), Collapsible(true)]
        public String Title { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }        
        public DateTime Dob { get; set; }
        public DateTime HireDate { get; set; }
        public Int32 SkillId { get; set; }
        public Int32 CertificationId { get; set; }
        [Category("Address"), Collapsible(true)]
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        [Category("Contact"), Collapsible(true)]
        public String Email { get; set; }
        public String Phone1 { get; set; }
        public Int16 Phone1Type { get; set; }
        public String Phone2 { get; set; }
        public Int16 Phone2Type { get; set; }
        public String Notes { get; set; }
        
        
    }
}