using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public BillController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetAllBill")]
        public async Task<ActionResult<BillProductConst>> GetAllBill()
        {
            var a = await _productDbContact.Bills.FromSqlRaw("Dm_Bill_GetAllBill").ToListAsync();
            return Ok(a);
        }
        [HttpGet("SortBill")]
        public async Task<ActionResult<BillProductConst>> SortBill()
        {
            var a = await _productDbContact.Bills.FromSqlRaw("Dm_Bill_Sort").ToListAsync();
            return Ok(a);
        }
        [HttpGet("SearchBill")]
        public async Task<ActionResult<BillProductConst>> SearchBill(string search)
        {
            var a = await _productDbContact.Bills.FromSqlRaw($"Dm_Bill_Search {search}").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetAllBillByUserId")]
        public async Task<ActionResult<BillConst>> GetAllBillByUserId(int userid)
        {
            var a = await _productDbContact.Bills.FromSqlRaw($"Dm_Bill_GetByUserid {userid}").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetBillByUserId")]
        public async Task<ActionResult<BillConst>> GetBillByUserId(int userid)
        {
            var a = await _productDbContact.Bills.FromSqlRaw($"Dm_Bill_GetByUserid {userid}").ToListAsync();
            return Ok(a[a.Count - 1]);
        }
        [HttpPost("AddBill")]
        public async Task<ActionResult<BillConst>> AddBill(BillConst bill)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bill_Create {bill.User_id},{bill.Bill_Count},{bill.Bill_Total}");
            var b = await _productDbContact.Bills.FromSqlRaw($"Dm_Bill_GetByUserid {bill.User_id}").ToListAsync();
            return Ok(b[b.Count - 1]);
        }
        [HttpPost("UpdateBill")]
        public async Task<ActionResult<BillConst>> UpdateBill(BillConst bill)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Bill_Update {bill.Bill_id},{bill.User_id},{bill.Bill_Count},{bill.Bill_Total},{bill.Bill_Status}");
            return Ok(a);
        }
    }
}
