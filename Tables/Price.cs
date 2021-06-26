using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaternityWard.Tables
{
    class Price
    {
        [Required]
        [Key]
        public string PriceName { get; set; }
        [Required]
        public float PriceValue { get; set; }
        [Required]
        public List<RankBonus> Bonuses { get; set; }

    }
}
