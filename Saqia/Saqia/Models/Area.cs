using System.ComponentModel.DataAnnotations;

namespace Saqia.Models
{
    public class Area
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        //زبائن في هذه المنطقة
        public ICollection<Customer> Customers { get; set; }
        // الخزانات التي تغطي هذه المنطقة عبر جدول وسيط
        public ICollection<TankArea> TankArea { get; set; }
    }
}
