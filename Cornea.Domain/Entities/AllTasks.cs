using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cornea.Domain.Entities
{
    public class AllTasks
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public LoginInfo loginInfo { get; set; }
        
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string TaskName { get; set; }
        [Required]
        public string Owner { get; set; }
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
        public string Filedir { get; set; }
    }
}
