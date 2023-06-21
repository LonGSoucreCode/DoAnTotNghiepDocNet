using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageProductController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        private readonly IWebHostEnvironment _enviroment;

        public ImageProductController(ProductDbContact productDbContact, IWebHostEnvironment enviroment)
        {
            _productDbContact = productDbContact;
            _enviroment = enviroment;
        }
        [HttpGet("GetAllImageProduct")]
        public async Task<ActionResult<List<Image_Product>>> GetAllImageProduct()
        {
            var a = await _productDbContact.Image_Products.FromSqlRaw("Dm_ImageProduct_List").ToListAsync();
            return Ok(a);
        }
        [HttpGet("GetImageProductByID{id}")]
        public async Task<ActionResult<List<Image_Product>>> GetImageProductById(int id)
        {
            var a = await _productDbContact.Image_Products.FromSqlRaw($"Dm_ImageProduct_ById {id}").ToListAsync();
            return Ok(a[0]);
        }
        [HttpGet("DeleteImageProduct{id}")]
        public async Task<ActionResult<int>> DeleteProduct(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_ImageProduct_Delete {id}");
            return Ok(a);
        }
        [HttpGet("RestoreImageProduct{id}")]
        public async Task<ActionResult<int>> RestoreProduct(int id)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_ImageProduct_Ative {id}");
            return Ok(a);
        }


        [HttpPost("UpLoadImageMain")]
        public async Task<ActionResult> UpLoadImage()
        {
            bool Results = false;
            var file = Request.Form.Files;
            foreach (IFormFile source in file)
            {
                string Filename = source.FileName;
                string Filepath = GetFilePath(Filename);
                try
                {
                    if (!System.IO.Directory.Exists(Filepath))
                    {
                        System.IO.Directory.CreateDirectory(Filepath);
                    }

                    string imagepath = Filepath + "\\image.png";
                    if (System.IO.Directory.Exists(imagepath))
                    {
                        System.IO.Directory.Delete(imagepath);
                    }
                    using (FileStream stream = System.IO.File.Create(imagepath))
                    {
                        await source.CopyToAsync(stream);
                        Results = true;
                    }
                }
                catch(HttpRequestException ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return Ok(Results);
        }

        [NonAction]
        private string GetFilePath(string ProductCode)
        {
            return this._enviroment.WebRootPath + "\\Image\\MainImage\\" + ProductCode;
        }

        [NonAction]
        private string GetImageMain(string ProductCode)
        {
            string ImageUrl = string.Empty;
            string HostUrl = "https://localhost:44323/";
            string Filepath= GetFilePath(ProductCode);
            string Imagepath = Filepath + "\\Image.png";
            if (!System.IO.File.Exists(Imagepath))
            {
                ImageUrl = HostUrl + "Image/MainImage/noimage.png";
            }
            else
            {
                ImageUrl = HostUrl + "Image/MainImage/" + ProductCode + "/image.png";
            }
            return ImageUrl;
        }

        //[HttpGet("GetAll")]
        //public async Task<List<Image_Product>> GetAll()
        //{
        //}

    }
}
