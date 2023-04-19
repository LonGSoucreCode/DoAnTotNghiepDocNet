using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CT_SizeController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public CT_SizeController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetAllCTSize")]
        public async Task<ActionResult<List<CT_Size>>> GetAllCTSize()
        {
            var a = await _productDbContact.CT_Sizes.FromSqlRaw("Dm_Size_GetAllCT_Size").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetAllSizeId{id}")]
        public async Task<ActionResult<List<CT_SizeConst>>> GetSizeBySizeId(int id)
        {
            var a = await _productDbContact.CT_Sizes.FromSqlRaw($"Dm_Size_GetBySizeId {id}").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetAllProductId{id}")]
        public async Task<ActionResult<List<CT_SizeConst>>> GetAllProductId(int id)
        {
            var a = await _productDbContact.CT_Sizes.FromSqlRaw($"Dm_Size_GetAllSizeByProductId {id}").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetSizeByProductId")]
        public async Task<ActionResult<List<CT_Size>>> GetSizeByProductId(int id, int size)
        {
            var a = await _productDbContact.CT_Sizes.FromSqlRaw($"Dm_Size_GetSizeByCTSizeId {id},{size}").ToListAsync();
            return Ok(a[0]);
        }
        [HttpPost("AddSizeByProductID")]
        public async Task<ActionResult<int>> AddSizeByProductID(CT_SizeConst c)
        {
            var a = await _productDbContact.CT_Sizes.FromSqlRaw($"Dm_Size_GetSizeByCTSizeId {c.Product_id}, {c.Size_id}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Size_AddSizeByProductID_Active {c.Product_id},{c.Size_id},{c.Size_Quantity},{c.Size_Surcharges}");
                return 0;
            }
            else
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Size_AddSizeByProductID {c.Product_id},{c.Size_id},{c.Size_Quantity},{c.Size_Surcharges}");
                return 1;
            }
        }
        [HttpPost("DeleteSizeByProductID")]
        public async Task<ActionResult<int>> DeleteProductInBag(int productid, int SizeId)
        {
            var a = await _productDbContact.CT_Sizes.FromSqlRaw($"Dm_Size_GetSizeByCTSizeId {productid},{SizeId}").ToListAsync();
            if (a.Count > 0)
            {
                var b = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Size_DeleteSizeByProductID {productid},{SizeId}");
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
