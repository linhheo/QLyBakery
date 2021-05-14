using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLyBakery.Models
{
    public partial class CuahangBanhDbContext : DbContext
    {
        public CuahangBanhDbContext()
            : base("name=CuahangBanhDbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<Kho> Khos { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
