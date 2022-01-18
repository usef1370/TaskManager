using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cornea.Domain.Entities
{
    public class Customers
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string LabName { get; set; }
        public long? Number { get; set; }
        public string ProductName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime SaleDate { get; set; }
    }
}
