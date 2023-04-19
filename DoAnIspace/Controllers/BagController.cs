using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BagController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public BagController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetBagByUserID{id}")]
        public async Task<ActionResult<int>> GetBagByUserID(int id)
        {
            var a = await _productDbContact.Bags.FromSqlRaw($"Dm_Bag_User {id}").ToListAsync();
            if (a.Count > 0)
            {
                return Ok(a[0].Bag_id);
            }
            return -1;
        }
        [HttpGet("AddBag{id}")]
        public async Task<ActionResult<int>> AddBag(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bag_Add {id}");
            var b = await _productDbContact.Bags.FromSqlRaw($"Dm_Bag_User {id}").ToListAsync();
            if (b.Count > 0)
            {
                return b[0].Bag_id;
            }
            return -1;
        }

        [HttpGet("SetBagCountByUserID{id}")]
        public async Task<ActionResult<List<Bag>>> SetBagCountByUserID(int id, int count)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bag_Count {id},{count}");
            return Ok(count);
        }
    }
}
