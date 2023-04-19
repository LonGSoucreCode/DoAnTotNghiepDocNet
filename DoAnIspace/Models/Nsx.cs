using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Nsx")]
    public class Nsx : IsCreateDelete
    {
        [Key]
        public int Nsx_id { get; set; }
        public string Nsx_Name { get; set; }
    }
}
