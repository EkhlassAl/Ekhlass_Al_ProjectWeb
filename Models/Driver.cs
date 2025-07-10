﻿using System.ComponentModel.DataAnnotations;

namespace Saqia.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Phone]
        public string Phone { get; set; }

        // الطلبات التي ينفذها هذا السائق
        public ICollection<Order> Orders { get; set; }
    }
}
