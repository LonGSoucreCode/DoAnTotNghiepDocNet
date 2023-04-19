using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CT_BagController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public CT_BagController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetBagByBagID{id}")]
        public async Task<ActionResult<List<CT_Bag>>> GetBagByBagID(int id)
        {
            var a = await _productDbContact.CT_Bags.FromSqlRaw($"Dm_Bag_UserID {id}").ToListAsync();
            return Ok(a);
        }
        [HttpPost("GetBagProduct")]
        public async Task<ActionResult<int>> GetBagProduct(CT_BagConst c)
        {
            var a = await _productDbContact.CT_Bags.FromSqlRaw($"Dm_Bag_GetProduct {c.Bag_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                if (a[0].IsActive == true)
                {
                    return Ok(a[0].CT_Bag_id);
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }
        [HttpPost("AddProductInBag")]
        public async Task<ActionResult<int>> AddProductInBag(CT_AddBagConst c)
        {
            var a = await _productDbContact.CT_Bags.FromSqlRaw($"Dm_Bag_GetProduct {c.Bag_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bag_AddProductActive {c.Bag_id},{c.Product_id},{c.Size_id}");
                return 0;
            }
            else
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bag_AddProduct {c.Bag_id},{c.Product_id},{c.Size_id},{c.Quality}");
                return 1;
            }
        }
        [HttpPost("UpdateProductInBag")]
        public async Task<ActionResult<int>> UpdateProductInWishList(CT_AddBagConst c)
        {
            var a = await _productDbContact.CT_Bags.FromSqlRaw($"Dm_Bag_GetProduct {c.Bag_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bag_UpdateProduct {c.Bag_id},{c.Product_id},{c.Size_id},{c.Quality}");
                return 0;
            }
            else
            {
                return 1;
            }
        }
        [HttpPost("DeleteProductInBag")]
        public async Task<ActionResult<int>> DeleteProductInBag(CT_BagConst c)
        {
            var a = await _productDbContact.CT_Bags.FromSqlRaw($"Dm_Bag_GetProduct {c.Bag_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bag_DeleteProduct {c.Bag_id},{c.Product_id},{c.Size_id}");
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
