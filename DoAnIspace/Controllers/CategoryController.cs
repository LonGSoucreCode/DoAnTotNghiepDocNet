using DoAnIspace.Const;
using DoAnIspace.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public CategoryController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetCategory")]
        public async Task<ActionResult<List<CategoryConst>>> GetCategory()
        {
            var a = await _productDbContact.Categorys.FromSqlRaw("Dm_Category_Get").ToListAsync();
            return Ok(a);
        }
    }
}
