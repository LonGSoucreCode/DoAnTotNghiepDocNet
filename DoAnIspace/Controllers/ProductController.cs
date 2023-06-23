using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnCuoiNam.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public ProductController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }

        [HttpGet("GetAllProduct")]
        public async Task<ActionResult<List<ProductConst>>> GetAllProduct()
        {
            var a = await _productDbContact.Products.FromSqlRaw("Dm_Product_List").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetProductByID{id}")]
        public async Task<ActionResult<List<ProductConst>>> GetProductById(int id)
        {
            var a = await _productDbContact.Products.FromSqlRaw($"Dm_Product_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
        [HttpPost("AddProduct")]
        public async Task<ActionResult<int>> AddProduct(ProductConstAdd p)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Product_Add {p.Product_Name},{p.Product_Price},{p.Brand_id},{p.Product_Story},{p.Category_id},{p.Sale_id}");
            return Ok(a);
        }
        [HttpPost("UpdateProduct")] 
        public async Task<ActionResult<int>> UpdateProduct(ProductConst p)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Product_Update {p.Product_id},{p.Image_Product_id},{p.Product_Name},{p.Product_Price},{p.Brand_id},{p.Product_Story},{p.Category_id},{p.Sale_id}");
            return Ok(a);
        }

        [HttpGet("DeleteProduct{id}")]
        public async Task<ActionResult<int>> DeleteProduct(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Product_Delete {id}");
            return Ok(a);
        }
        [HttpGet("RestoreProduct{id}")]
        public async Task<ActionResult<int>> RestoreProduct(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Product_Active {id}");
            return Ok(a);
        }
        [HttpGet("Search")]
        public async Task<ActionResult<List<ProductConst>>> Search(string search)
        {
            var a = await _productDbContact.Products.FromSqlRaw($"Dm_Product_Search {search}").ToListAsync();
            return Ok(a);
        }
    }
}
