using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharacterSheetDbFirst.Models
{
    public partial class Skills
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public int? SkillCost { get; set; }
        public string SkillClass { get; set; }
    }
}
