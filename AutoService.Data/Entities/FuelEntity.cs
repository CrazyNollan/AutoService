using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("Fuel")]
    public class FuelEntity
    {
        [Required]
        [Column(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Name))]
        public string Name { get; set; }

        [ForeignKey("FuelId")]
        public ICollection<TransportEntity> Transport { get; set; }
    }
}