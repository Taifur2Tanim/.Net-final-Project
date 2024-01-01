using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class WishProduct
    {
        [Key]
        public int WishlistID { get; set; }

        [Required]
        public string WishProductName { get; set; }

        [Required]
        public string WishProductDescription { get; set; }

        [ForeignKey("User")]
        public string AskedBy { get; set; }

        public virtual User User { get; set; }
    }
}