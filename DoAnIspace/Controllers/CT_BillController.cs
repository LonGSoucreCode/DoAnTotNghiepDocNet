using DoAnIspace.Const;
using DoAnIspace.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CT_BillController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public CT_BillController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetAllByBillID")]
        public async Task<ActionResult<BillProductConst>> GetAllByBillID(int id)
        {
            var a = await _productDbContact.CT_Bills.FromSqlRaw($"Dm_Bill_GetAllByBillID {id}").ToListAsync();
            return Ok(a);
        }
        [HttpPost("CreateBillProduct")]
        public async Task<ActionResult<BillProductConst>> CreateBillProduct(BillProductConst bill)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_CT_Bill_Create {bill.Bill_id},{bill.Product_id},{bill.Product_Price},{bill.Size_id}");
            return Ok(a);
        }
    }
}
