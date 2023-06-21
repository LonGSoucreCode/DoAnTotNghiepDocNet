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
        [HttpGet("AddCategory")]
        public async Task<ActionResult<List<CategoryConst>>> AddCategory()
        {
            var a = await _productDbContact.Categorys.FromSqlRaw("Dm_Category_Get").ToListAsync();
            return Ok(a);
        }
        [HttpGet("DeleteCategory")]
        public async Task<ActionResult<List<CategoryConst>>> DeleteCategory()
        {
            var a = await _productDbContact.Categorys.FromSqlRaw("Dm_Category_Get").ToListAsync();
            return Ok(a);
        }
        [HttpGet("RestoreCategory")]
        public async Task<ActionResult<List<CategoryConst>>> RestoreCategory()
        {
            var a = await _productDbContact.Categorys.FromSqlRaw("Dm_Category_Get").ToListAsync();
            return Ok(a);
        }
    }
}
