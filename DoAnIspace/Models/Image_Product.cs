using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Image_Product")]
    public class Image_Product : IsCreateDelete
    {
        [Key]
        public int Image_Product_id { get; set; }
        public string Image_Product_Main { get; set; }
        public string Image_Product_Detail { get; set; }
        public string Image_Product_Ass { get; set; }
        public string Image_Product_Cond { get; set; }
    }
}
