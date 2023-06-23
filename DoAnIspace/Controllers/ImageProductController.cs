using DoAnIspace.Const;
using DoAnIspace.Data;
using DoAnIspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static System.Net.WebRequestMethods;

namespace DoAnIspace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageProductController : Controller
    {
        private readonly ProductDbContact _productDbContact;
        private readonly IWebHostEnvironment _environment;

        public ImageProductController(ProductDbContact productDbContact, IWebHostEnvironment enviroment)
        {
            _productDbContact = productDbContact;
            _environment = enviroment;
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
        [HttpPost("AddImageProduct")]
        public async Task<ActionResult<int>> AddImageProduct(Imge_ProductConts_Add img)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_ImageProduct_Add {img.Image_Product_Main},{img.Image_Product_Detail},{img.Image_Product_Ass},{img.Image_Product_Cond}");
            return Ok(a);
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

        [HttpPost("UpdateImage")]
        public async Task<ActionResult<int>> UpdateImage(Imge_ProductConts img)
        {
            var a = await _productDbContact.Database.ExecuteSqlRawAsync($"Dm_ImageProduct_UpdateLink {img.Image_Product_id},{img.Image_Product_Main},{img.Image_Product_Detail},{img.Image_Product_Ass},{img.Image_Product_Cond}");
            return Ok(a);
        }

        [HttpPost("UpLoadImageMain")]
        public async Task<ActionResult> UpLoadImageMain()
        {
            bool Results = false;
            try
            {
                var _uploadfiles = Request.Form.Files;
                foreach(IFormFile source in _uploadfiles)
                {
                    string Filename = source.FileName.Replace(".jpg","");
                    string Filepath = GetFilePath(Filename);

                    if (!System.IO.Directory.Exists(Filepath))
                    {
                        System.IO.Directory.CreateDirectory(Filepath);
                    }

                    string imagepath = Filepath + "\\image1.jpg";

                    if (System.IO.Directory.Exists(imagepath))
                    {
                        System.IO.Directory.Delete(imagepath);
                    }
                    using(FileStream stream = System.IO.File.Create(imagepath))
                    {
                        await source.CopyToAsync(stream);

                        Results = true;
                    }
                }

            }
            catch (Exception ex) 
            {

            }
            return Ok(Results);
        }

        [HttpPost("UpLoadImageDetail")]
        public async Task<ActionResult> UpLoadImageDetail()
        {
            bool Results = false;
            try
            {
                var _uploadfiles = Request.Form.Files;
                foreach (IFormFile source in _uploadfiles)
                {
                    string Filename = source.FileName.Replace(".jpg", "");
                    string Filepath = GetFilePath(Filename);

                    if (!System.IO.Directory.Exists(Filepath))
                    {
                        System.IO.Directory.CreateDirectory(Filepath);
                    }

                    string imagepath = Filepath + "\\image2.jpg";

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

            }
            catch (Exception ex)
            {

            }
            return Ok(Results);
        }

        [HttpPost("UpLoadImageAss")]
        public async Task<ActionResult> UpLoadImageAss()
        {
            bool Results = false;
            try
            {
                var _uploadfiles = Request.Form.Files;
                foreach (IFormFile source in _uploadfiles)
                {
                    string Filename = source.FileName.Replace(".jpg", "");
                    string Filepath = GetFilePath(Filename);

                    if (!System.IO.Directory.Exists(Filepath))
                    {
                        System.IO.Directory.CreateDirectory(Filepath);
                    }

                    string imagepath = Filepath + "\\image3.jpg";

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

            }
            catch (Exception ex)
            {

            }
            return Ok(Results);
        }

        [HttpPost("UpLoadImageCond")]
        public async Task<ActionResult> UpLoadImageCond()
        {
            bool Results = false;
            try
            {
                var _uploadfiles = Request.Form.Files;
                foreach (IFormFile source in _uploadfiles)
                {
                    string Filename = source.FileName.Replace(".jpg", "");
                    string Filepath = GetFilePath(Filename);

                    if (!System.IO.Directory.Exists(Filepath))
                    {
                        System.IO.Directory.CreateDirectory(Filepath);
                    }

                    string imagepath = Filepath + "\\image4.jpg";

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

            }
            catch (Exception ex)
            {

            }
            return Ok(Results);
        }

        [NonAction]
        private string GetFilePath(string ProductCode)
        {
            return this._environment.WebRootPath + "\\Uploads\\Product\\" + ProductCode; 
        }

        [NonAction]
        private string GetImagebyProduct(string ProductCode)
        {
            string ImageUrl = string.Empty;
            string HostUrl = "https://localhost:44323/";
            string Filepath = GetFilePath(ProductCode);
            string Imagepath = Filepath + "\\Image.png";
            if(!System.IO.File.Exists(Imagepath))
            {
                ImageUrl = HostUrl + "/upLoads/common/noimage.png";
            }
            else
            {
                ImageUrl = HostUrl + "/upLoads/product/mainImage/" + ProductCode + "/image.png";
            }
            return ImageUrl;
        }

    }
}
