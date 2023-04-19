using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_CT_Bill")]
    public class CT_Bill : IsCreateDelete
    {
        [Key]
        public int CT_Bill_id { get; set; }
        public int Bill_id { get; set; }
        public int Product_id { get; set; }
        public string Product_Price { get; set; }
        public int Size_id { get; set; }
    }
}
