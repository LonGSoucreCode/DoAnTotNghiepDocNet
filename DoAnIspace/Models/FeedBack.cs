using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_FeedBack")]
    public class FeedBack : IsCreateDelete
    {
        [Key]
        public int FeedBack_id { get; set; }
        public int FeedBack_Status { get; set; }
        public int User_id { get; set; }
    }
}
