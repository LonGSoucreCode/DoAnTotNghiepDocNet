using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CT_WishListController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public CT_WishListController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetWishListByWishListId{id}")]
        public async Task<ActionResult<List<CT_WishList>>> GetWishListByWishListId(int id)
        {
            var a = await _productDbContact.CT_WishLists.FromSqlRaw($"Dm_WishList_UserID {id}").ToListAsync();
            return Ok(a);
        }
        [HttpPost("GetWishListProduct")]
        public async Task<ActionResult<int>> GetWishListProduct(CT_WishListConst c)
        {
            var a = await _productDbContact.CT_WishLists.FromSqlRaw($"Dm_WishList_GetProduct {c.WishList_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                if (a[0].IsActive == true)
                {
                    return Ok(a[0].Size_id);
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }
        //[HttpPost("GetWishListProductBag")]
        //public async Task<ActionResult<int>> GetWishListProductBag(CT_WishListConst c)
        //{
        //    var a = await _productDbContact.CT_WishLists.FromSqlRaw($"Dm_WishList_GetProduct {c.WishList_id},{c.Product_id},{c.Size_id}").ToListAsync();
        //    if (a.Count > 0)
        //    {
        //        if (a[0].IsActive == true)
        //        {
        //            return Ok(a[0].CT_WishList_id);
        //        }
        //        return -1;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}
        [HttpPost("AddProductInWishList")]
        public async Task<ActionResult<int>>AddProductInWishList(CT_WishListConst c)
        {
            var a = await _productDbContact.CT_WishLists.FromSqlRaw($"Dm_WishList_GetProduct {c.WishList_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_WishList_AddProductActive {c.WishList_id},{c.Product_id},{c.Size_id}");
                return 0;
            }
            else
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_WishList_AddProduct {c.WishList_id},{c.Product_id},{c.Size_id}");
                return 1;
            }
        }
        [HttpPost("UpdateProductInWishList")]
        public async Task<ActionResult<int>> UpdateProductInWishList(CT_WishlistAddConst c)
        {
            var a = await _productDbContact.CT_WishLists.FromSqlRaw($"Dm_WishList_GetProduct {c.WishList_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_WishList_UpdateProduct  {c.WishList_id},{c.Product_id},{c.Size_id},{c.Size_id_New}");
                return 0;
            }
            else
            {
                return 1;
            }
        }
        [HttpPost("DeleteProductInWishList")]
        public async Task<ActionResult<int>> DeleteProductInWishList(CT_WishListConst c)
        {
            var a = await _productDbContact.CT_WishLists.FromSqlRaw($"Dm_WishList_GetProduct {c.WishList_id},{c.Product_id},{c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_WishList_DeleteProduct {c.WishList_id},{c.Product_id},{c.Size_id}");
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
