using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLyBakery.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string IDMon { get; set; }
        public string TenMon { get; set; }
        public string Dongia { get; set; }
    }
}