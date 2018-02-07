
namespace SayugaSol.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Certification")]
    [BasedOnRow(typeof(Entities.CertificationRow))]
    public class CertificationForm
    {
        public String Name { get; set; }
        public DateTime DateAcquired { get; set; }
        public DateTime ExpirationDate { get; set; }
        public String Description { get; set; }

    }
}