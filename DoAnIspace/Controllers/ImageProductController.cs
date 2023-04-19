using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageProductController : Controller
    {
        private readonly ProductDbContact _productDbContact;

        public ImageProductController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetAllImageProduct")]
        public async Task<ActionResult<List<Image_Product>>> GetAllImageProduct()
        {
            var a = await _productDbContact.Image_Products.FromSqlRaw("Dm_ImageProduct_List").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetImageProductByID{id}")]
        public async Task<ActionResult<List<Image_Product>>> GetImageProductById(int id)
        {
            var a = await _productDbContact.Image_Products.FromSqlRaw($"Dm_ImageProduct_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
        [HttpGet("DeleteImageProduct{id}")]
        public async Task<ActionResult<int>> DeleteProduct(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_ImageProduct_Delete {id}");
            return Ok(a);
        }
        [HttpGet("RestoreImageProduct{id}")]
        public async Task<ActionResult<int>> RestoreProduct(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_ImageProduct_Ative {id}");
            return Ok(a);
        }

    }
}
