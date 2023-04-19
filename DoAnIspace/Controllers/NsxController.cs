using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NsxController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public NsxController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetNsxByID{id}")]
        public async Task<ActionResult<List<Nsx>>> GetNsxById(int id)
        {
            var a = await _productDbContact.Nsxs.FromSqlRaw($"Dm_Nsx_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
    }
}
