using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharacterSheetDbFirst.Models
{
    public partial class Characters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RaceId { get; set; }

        public int? Vitality { get; set; }               //4
        public int? Strength { get; set; }
        public int? Endurance { get; set; }
        public int? Toughtness { get; set; }

        public int? Dexterity { get; set; }              //8
        public int? Agility { get; set; }
        public int? Perception { get; set; }
        public int? Quickness { get; set; }

        public int? Intuition { get; set; }              //12
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Resourcefull { get; set; }

        public int? Charisma { get; set; }               //16
        public int? Appearance { get; set; }
        public int? Influence { get; set; }
        public int? Luck { get; set; }

        public int? SkillId { get; set; }

        public virtual Races Race { get; set; }
    }
}
