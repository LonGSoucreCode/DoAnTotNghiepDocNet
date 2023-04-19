using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SizeController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public SizeController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetAllSize")]
        public async Task<ActionResult<List<SizeConst>>> GetAllSize()
        {
            var a = await _productDbContact.Sizes.FromSqlRaw("exec Dm_Size_Get").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetSizeBySizeId{id}")]
        public async Task<ActionResult<List<SizeConst>>> GetSizeBySizeId(int id)
        {
            var a = await _productDbContact.Sizes.FromSqlRaw($"Dm_Size_GetSizeBySizeID {id}").ToListAsync();
            return Ok(a[0]);
        }
    }
}
