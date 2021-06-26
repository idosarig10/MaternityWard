using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaternityWard
{
    [Keyless]
    class MonthWorkHours
    {
        [ForeignKey("WorkerId")]
        public Worker Worker { get; set; }
        public float Hours { get; set; }
    }

}
