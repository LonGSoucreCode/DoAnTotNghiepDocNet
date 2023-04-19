using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_CT_View")]
    public class CT_View : IsCreateDelete
    {
        [Key]
        public int CT_View_id { get; set; }
        public int View_id { get; set; }
        public int User_id { get; set; }
    }
}
