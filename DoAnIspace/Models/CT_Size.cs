using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DoAnIspace.Models
{
    [Table("DM_CT_Size")]
    public class CT_Size : IsCreateDelete
    {
        [Key]
        public int CT_Size_id { get; set; }
        public int Size_id { get; set; }
        public int Product_id { get; set; }
        public int Size_Quantity { get; set; }
        public string Size_Surcharges { get; set; }
    }
}
