using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Bag")]
    public class Bag : IsCreateDelete
    {
        [Key]
        public int Bag_id { get; set; }
        public int User_id { get; set; }
        public int Bag_Count { get; set; }
    }
}
