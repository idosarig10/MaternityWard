using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaternityWard.Tables
{
    class RankBonus
    {
        [Required] 
        [Key]
        public string Rank { get; set; }
        [Required]
        public float BonusPercentages { get; set; }   

    }
}