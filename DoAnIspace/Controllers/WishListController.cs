using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishListController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public WishListController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetWishListByUserID{id}")]
        public async Task<ActionResult<int>> GetWishListByUSerId(int id)
        {
            var a = await _productDbContact.WishLists.FromSqlRaw($"Dm_WishList_User {id}").ToListAsync();
            if(a.Count > 0) {

                return Ok(a[0].WishList_id);
            }
            return -1;
        }
         [HttpGet("AddWishList{id}")]
        public async Task<ActionResult<int>> AddWishList(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_WishList_Add {id}");
            var b = await _productDbContact.WishLists.FromSqlRaw($"Dm_WishList_User {id}").ToListAsync();
            if (b.Count > 0)
            {
                return b[0].WishList_id;
            }
            return -1;
        }
        [HttpGet("SetWishListCountByUserID{id}")]
        public async Task<ActionResult<List<WishList>>> SetWishListCountByUserID(int id, int count)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_WishList_Count {id},{count}");
            return Ok(count);
        }
    }
}
