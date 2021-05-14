using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLyBakery.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string NhanvienID { get; set; }
        public string TenNhanvien { get; set; }
        public string SoDienThoai { get; set; }
        public string SoTaiKhoan { get; set; }
    }
}