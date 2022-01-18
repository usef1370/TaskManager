using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cornea.Domain.Entities
{
    public class Factors
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string FactorNumber { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public long Number { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Issuancedate{get;set;}
        [Required]
        public string Imagedir { get; set; }
    }
}
