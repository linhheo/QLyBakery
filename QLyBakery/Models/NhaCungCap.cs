using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLyBakery.Models
{
    [Table("NhaCungCaps")]
    public class NhaCungCap
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string NhacungcapID { get; set; }
        public string TenNhacungcap { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string SoTaiKhoan { get; set; }
        public string Email { get; set; }
    }
}