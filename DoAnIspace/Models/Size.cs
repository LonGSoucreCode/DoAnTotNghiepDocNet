using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Size")]
    public class Size : IsCreateDelete
    {
        [Key]
        public int Size_id { get; set; }
        public string Size_Number { get; set; }
    }
}
