
namespace SayugaSol.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Skill")]
    [BasedOnRow(typeof(Entities.SkillRow))]
    public class SkillForm
    {
        public String Name { get; set; }
        public String Description { get; set; }
    }
}