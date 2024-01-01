using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WishProductDTO
    {
        public int WishlistID { get; set; }

        [Required]
        public string WishProductName { get; set; }

        [Required]
        public string WishProductDescription { get; set; }

        public string AskedBy { get; set; }
    }
}