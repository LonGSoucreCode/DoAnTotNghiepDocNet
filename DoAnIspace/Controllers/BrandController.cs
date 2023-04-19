using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public BrandController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetAllBrand")]
        public async Task<ActionResult<List<BrandConst>>> GetAllBrand()
        {
            var a = await _productDbContact.Brands.FromSqlRaw("Dm_Brand_Get").ToListAsync();
            return Ok(a);
        }

        [HttpGet("GetBrandByID{id}")]
        public async Task<ActionResult<List<BrandConst>>> GetBrandById(int id)
        {
            var a = await _productDbContact.Brands.FromSqlRaw($"Dm_Brand_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
    }
}
