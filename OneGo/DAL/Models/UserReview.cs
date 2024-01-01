using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserReview
    {
        [Key]
        public int UserReviewID { get; set; }

        [Required]
        public string ReviewDescription { get; set; }

        [ForeignKey("User")]
        public string ReviewedBy { get; set; }

        public virtual User User { get; set; }
    }
}
