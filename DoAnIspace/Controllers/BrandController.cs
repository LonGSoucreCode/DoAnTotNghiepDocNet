﻿using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public BrandController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpGet("GetAllBrand")]
        public async Task<ActionResult<List<BrandConst>>> GetAllBrand()
        {
            var a = await _productDbContact.Brands.FromSqlRaw("Dm_Brand_Get").ToListAsync();
            return Ok(a);
        }

        [HttpGet("GetBrandByID{id}")]
        public async Task<ActionResult<List<BrandConst>>> GetBrandById(int id)
        {
            var a = await _productDbContact.Brands.FromSqlRaw($"Dm_Brand_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
        [HttpGet("AddBrand")]
        public async Task<ActionResult<int>> AddBrand(string name, int nsx)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Brand_Add {name},{nsx}");
            return 0;
        }
        [HttpPost("UpdateBrand")]
        public async Task<ActionResult<int>> UpdateBrand(BrandConst brand)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Brand_Update {brand.Brand_id},{brand.Brand_Name},{brand.Nsx_id}");
            return Ok(a);
        }
        [HttpGet("DeleteBrand")]
        public async Task<ActionResult<int>> DeleteBrand(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Brand_Delete {id}");
            return 0;
        }
        [HttpGet("RestoreBrand")]
        public async Task<ActionResult<int>> RestoreBrand(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_Brand_Restore {id}");
            return 0;
        }
    }
}
