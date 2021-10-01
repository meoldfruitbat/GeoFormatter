using System;
using System.Collections.Generic;

#nullable disable

namespace GeoJsonFormatter.Models
{
    public partial class PublicUtilityDamageType
    {
        public int Id { get; set; }
        public string DamageGroup { get; set; }
        public string DamageType { get; set; }
        public string DamageColour { get; set; }
        public string QuestionOne { get; set; }
        public string QuestionTwo { get; set; }
        public string QuestionThree { get; set; }
        public string QuestionFour { get; set; }
        public string Category { get; set; }
    }
}
