using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnIspace.Models
{
    [Table("DM_Product")]
    public class Product : IsCreateDelete
    {
        [Key]
        public int Product_id { get; set; }
        public int Image_Product_id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public int Brand_id { get; set; }
        public string Product_Story { get; set; }
        public int Category_id { get; set; }
        public int View_id { get; set; }
        public int Sale_id { get; set; }

    }
}
