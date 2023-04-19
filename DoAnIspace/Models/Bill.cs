using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Bill")]
    public class Bill : IsCreateDelete
    {
        [Key]
        public int Bill_id { get; set; }
        public int User_id { get; set; }
        public int Bill_Count { get; set; }
        public string Bill_Total { get; set; }
        public bool Bill_Status { get; set; }

    }
}
