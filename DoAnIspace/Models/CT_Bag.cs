using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_CT_bag")]
    public class CT_Bag : IsCreateDelete
    {
        [Key]
        public int CT_Bag_id { get; set; }
        public int Bag_id { get; set; }
        public int Product_id { get; set; }
        public int Size_id { get; set; }
        public string Quality { get; set; }
    }
}
