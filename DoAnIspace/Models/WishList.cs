using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_WishList")]
    public class WishList : IsCreateDelete
    {
        [Key]
        public int WishList_id { get; set; }
        public int User_id { get; set; }
        public int WishList_Count { get; set; }
    }
}
