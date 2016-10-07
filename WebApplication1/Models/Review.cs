using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Subject { get; set; }
        public DateTime ReviewDate { get; set; }
        public string ReviewSummary { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}