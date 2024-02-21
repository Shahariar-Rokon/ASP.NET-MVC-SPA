using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeV4.Models
{
    public class SaleMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "bigint")]
        public long SaleId { get; set; }
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string CustomerAddress { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string Gender { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(500)]
        public string Photo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ProductType { get; set; }
        [Column(TypeName = "VARCHAR")]
        public virtual IList<SaleDetail> SaleDetails { get; set; }
    }
}