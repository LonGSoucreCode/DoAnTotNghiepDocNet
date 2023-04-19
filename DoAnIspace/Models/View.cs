using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_View")]
    public class View : IsCreateDelete
    {
        [Key]
        public int View_id { get; set; }
        public int View_count { get; set; }
    }
}
