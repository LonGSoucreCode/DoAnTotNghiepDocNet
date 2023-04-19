using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Sale")]
    public class Sale : IsCreateDelete
    {
        [Key]
        public int Sale_id { get; set; }
        public string Sale_Price { get; set; }
        public bool Sale_Status { get; set; }
    }
}
