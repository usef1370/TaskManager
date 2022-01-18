using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cornea.Domain.Entities
{
    public class Projects
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime StartTime { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime FinishTime { get; set; }
        public string Message { get; set; }
        public long? PassedTime { get; set; }
        public long? Timeline { get; set; }
        public long? Percent { get; set; }
    }
}
