using DoAnIspace.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAnIspace.Data
{
    public class ProductDbContact : DbContext
    {
        public ProductDbContact(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bag> Bags { get; set; }
        public DbSet<Bill> Bills { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<CT_Bag> CT_Bags { get; set; }
        public DbSet<CT_Bill> CT_Bills { get; set; }
        public DbSet<CT_Size> CT_Sizes { get; set; }
        public DbSet<CT_View> CT_Views { get; set; }
        public DbSet<CT_WishList> CT_WishLists { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Image_Product> Image_Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Size> Sizes { get; set; }  
        public DbSet<User> Users { get; set; }
        public DbSet<View> Views { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Nsx> Nsxs { get; set; }
        public DbSet<ListCode> listCodes { get; set; }
    }
}
