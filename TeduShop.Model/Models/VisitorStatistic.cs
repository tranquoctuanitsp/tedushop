using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        public Guid ID { set; get; }

        [Required]
        public DateTime VisitedDate { set; get; }
        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
