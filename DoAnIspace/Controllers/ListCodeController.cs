using DoAnIspace.Const;
using DoAnIspace.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListCodeController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public ListCodeController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }

        [HttpGet("GetCode{id}")]
        public async Task<ActionResult<List<ListCodeConst>>> GetCode(int id)
        {
            var a = await _productDbContact.listCodes.FromSqlRaw($"Dm_ListCode_GetCode {id}").ToListAsync();
            return Ok(a);
        }
    }
}
