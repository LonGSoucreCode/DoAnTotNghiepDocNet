using DoAnIspace.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnIspace.Const
{
    public class ProductConst 
    {
        public int Product_id { get; set; }
        public int Image_Product_id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public int Brand_id { get; set; }
        public string Product_Story { get; set; }
        public int Category_id { get; set; }
        public int Sale_id { get; set; }
    }
    public class ProductConstAdd
    {
        public int Image_Product_id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public int Brand_id { get; set; }
        public string Product_Story { get; set; }
        public int Category_id { get; set; }
        public int Sale_id { get; set; }
    }
}
