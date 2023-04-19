using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Category")]
    public class Category : IsCreateDelete
    {
        [Key]
        public int Category_id { get; set; }
        public string Category_Name { get; set; }
    }
}
