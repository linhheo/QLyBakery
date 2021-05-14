using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLyBakery.Models
{
    [Table("Khos")]
    public class Kho
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string NguyenlieuID { get; set; }
        public string TenNguyenlieu { get; set; }
        public int Soluong { get; set; }
    }
}