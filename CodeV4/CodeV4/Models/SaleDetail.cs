using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeV4.Models
{
    public class SaleDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SaleDetailId { get; set; }
        [Column(TypeName = "bigint")]
        [ForeignKey("SaleMaster")]
        public long? SaleId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal")]
        public decimal Qty { get; set; }
        public SaleMaster SaleMaster { get; set; }
    }
}