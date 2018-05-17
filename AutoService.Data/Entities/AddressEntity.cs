using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("Addresses")]
    public class AddressEntity
    {
        [Required]
        [Column(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Country))]
        public string Country { get; set; }

        [Required]
        [Column(nameof(City))]
        public string City { get; set; }

        [Required]
        [Column(nameof(Street))]
        public string Street { get; set; }

        [Required]
        [Column(nameof(House))]
        public int House { get; set; }

        [ForeignKey("AddressId")]
        public ICollection<ClientEntity> Clients { get; set; }
    }
}