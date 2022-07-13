using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POSApplication.ForntEnd.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column("CustomerId")]
        [StringLength(10)]
        public string CustomerId { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Nama { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Alamat { get; set; } = null!;
        [StringLength(12)]
        public string Telp { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime TanggalJoin { get; set; }
    }
}
