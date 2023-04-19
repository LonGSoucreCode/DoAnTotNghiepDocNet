using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        public UserController(ProductDbContact productDbContact)
        {
            _productDbContact = productDbContact;
        }
        [HttpPost("AddUser")]
        public async Task<ActionResult<List<User>>> AddUser(UserConst u)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_User_Add {u.Email},{u.Password},{u.FirstName},{u.LastName}");
            return Ok(a);
        }
        [HttpGet("CheckEmailUser")]
        public async Task<ActionResult<int>> CheckEmailUser(string email)
        {
            var a = await _productDbContact.Users.FromSqlRaw($"DM_User_ByName {email}").ToListAsync();
            if (a.Count > 0)
            {
                if (a[0].IsActive == true)
                {
                    return a[0].User_id;
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }
        [HttpPost("GetUser")]
        public async Task<ActionResult<int>> GetUser(UserConst u)
        {
            var a = await _productDbContact.Users.FromSqlRaw($"Dm_UserLogin {u.Email},{u.Password}").ToListAsync();
            if(a.Count > 0 )
            {
                if (a[0].IsActive == true)
                {
                    return a[0].User_id;
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }

        [HttpPost("UpdateUser")]
        public async Task<ActionResult<List<User>>> UpdateUser(UserUpdateConst u)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_User_Update {u.User_id},{u.Credit}");
            return Ok(a);
        }


        [HttpGet("GetUserByID{id}")]
        public async Task<ActionResult<List<User>>> GetUserByID(int id)
        {
            var a = await _productDbContact.Users.FromSqlRaw($"Dm_User_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
        [HttpGet("GetAllUser")]
        public async Task<ActionResult<List<User>>> GetAllUser()
        {
            var a = await _productDbContact.Users.FromSqlRaw("Dm_User_GetAllUser").ToListAsync();
            return Ok(a);
        }
    }
}
