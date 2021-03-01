using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharacterSheetDbFirst.Models
{
    public partial class Racesskills
    {
        public int? RaceId { get; set; }
        public int? SkillId { get; set; }

        public virtual Races Race { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
