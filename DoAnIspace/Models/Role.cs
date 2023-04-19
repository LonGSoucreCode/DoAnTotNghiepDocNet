using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Role")]
    public class Role : IsCreateDelete
    {
        [Key]
        public int Role_id { get; set; }
        public string Role_Name { get; set; }
    }
}
