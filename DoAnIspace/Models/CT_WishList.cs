using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_CT_WishList")]
    public class CT_WishList : IsCreateDelete
    {
        [Key]
        public int CT_WishList_id { get; set; }
        public int WishList_id { get; set; }
        public int Product_id { get; set; }
        public int Size_id { get; set; }
    }
}
