using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cornea.Domain.Entities
{
    public class Products
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Imagedir { get; set; }
        public bool Status { get; set; }

    }
}
