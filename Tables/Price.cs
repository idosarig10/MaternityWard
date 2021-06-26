using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaternityWard
{
    class Price
    {
        [Key]
        public string PriceName { get; set; }
        public float PriceValue { get; set; }
        public List<RankBonus> Bonuses { get; set; }

    }
}
