using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Saqia.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        public int AreaId { get; set; }
        [ForeignKey("AreaId")]
        public Area Area { get; set; }

        // الطلبيات المرتبطة بهذا الزبون
        public ICollection<Order> Orders { get; set; }
    }
}
