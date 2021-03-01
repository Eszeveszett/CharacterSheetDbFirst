using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharacterSheetDbFirst.Models
{
    public partial class Abilitybonus
    {
        public int Id { get; set; }
        public int? AbilityValue { get; set; }
        public int? Active { get; set; }
        public int? Passive { get; set; }
    }
}
