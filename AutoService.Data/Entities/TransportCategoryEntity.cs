using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("TransportCategories")]
    public class TransportCategoryEntity
    {
        [Required]
        [Column(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Name))]
        public string Name { get; set; }

        [ForeignKey("TransportCategoryId")]
        public ICollection<DriverLicenseEntity> DriverLicenses { get; set; }

        [ForeignKey("TransportCategoryId")]
        public ICollection<TransportEntity> Transport { get; set; }
    }
}