using System.ComponentModel.DataAnnotations;

namespace MaternityWard
{
    class Prices
    {
        [Key]
        public string PriceName { get; set; }
        public float PriceValue { get; set; }
    }
}
