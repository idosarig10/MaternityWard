using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaternityWard
{
    class RankBonus
    {
        [Key]
        public string Rank { get; set; }
        public float BonusPercentages { get; set; }   

    }
}