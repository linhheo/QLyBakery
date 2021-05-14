using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLyBakery.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string KhachhangID { get; set; }
        public string TenKhachhang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}