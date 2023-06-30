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

        [HttpGet("GetAllNsx")]
        public async Task<ActionResult<List<Nsx>>> GetNsxById()
        {
            var a = await _productDbContact.Nsxs.FromSqlRaw("Dm_Nsx_GetAllNsx").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetNsxByID{id}")]
        public async Task<ActionResult<List<Nsx>>> GetNsxById(int id)
        {
            var a = await _productDbContact.Nsxs.FromSqlRaw($"Dm_Nsx_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
        [HttpGet("AddNsx")]
        public async Task<ActionResult<List<Nsx>>> AddNsxById(string name)
        {
            name = name.Replace(' ', '_');
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Nsx_Add {name}");
            return Ok(a);
        }
        [HttpGet("UpdateNsx")]
        public async Task<ActionResult<List<Nsx>>> UpdateNsx(int id,string name)
        {
            name = name.Replace(' ', '_');
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Nsx_Update {id},{name}");
            return Ok(a);
        }

        [HttpGet("DeleteNsx")]
        public async Task<ActionResult<List<Nsx>>> DeleteNsxById(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Nsx_Delete {id}");
            return Ok(a);
        }

        [HttpGet("RestoreNsx")]
        public async Task<ActionResult<List<Nsx>>> RestoreNsxById(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Nsx_Active {id}");
            return Ok(a);
        }
    }
}
