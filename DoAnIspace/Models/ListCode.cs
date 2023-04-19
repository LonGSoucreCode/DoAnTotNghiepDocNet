using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnIspace.Models
{
    [Table("DM_ListCode")]
    public class ListCode : IsCreateDelete
    {
        [Key]
        public int List_id { get; set; }
        public string List_code { get; set; }
        public string List_name { get; set; }
    }
}
