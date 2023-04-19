using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Brand")]
    public class Brand : IsCreateDelete
    {
        [Key]
        public int Brand_id { get; set; }
        public string Brand_Name { get; set; }
        public int Nsx_id { get; set; }

    }
}
