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
        [HttpGet("GetCategoryById")]
        public async Task<ActionResult<List<CategoryConst>>> GetCategoryById(int id)
        {
            var a = await _productDbContact.Categorys.FromSqlRaw($"Dm_Category_GetById {id}").ToListAsync();
            return Ok(a);
        }
        [HttpGet("AddCategory")]
        public async Task<ActionResult<List<CategoryConst>>> AddCategory(string name)
        {
            name = name.Replace(' ', '_');
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Category_Add {name}");
            return Ok(a);
        }
        [HttpGet("UpdateCategory")]
        public async Task<ActionResult<List<CategoryConst>>> UpdateCategory(int id, string name)
        {
            name = name.Replace(' ', '_');
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Category_Update {id},{name}");
            return Ok(a);
        }
        [HttpGet("DeleteCategory")]
        public async Task<ActionResult<List<CategoryConst>>> DeleteCategory(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Category_Delete {id}");
            return Ok(a);
        }
        [HttpGet("RestoreCategory")]
        public async Task<ActionResult<List<CategoryConst>>> Dm_Category_Active(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Category_Active {id}");
            return Ok(a);
        }
    }
}
