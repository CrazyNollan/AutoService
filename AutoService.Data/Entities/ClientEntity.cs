using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("Clients")]
    public class ClientEntity
    {
        [Required]
        [Column(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Name))]
        public string Name { get; set; }

        [Required]
        [Column(nameof(Surname))]
        public string Surname { get; set; }

        [Required]
        [Column(nameof(Patronymic))]
        public string Patronymic { get; set; }

        [Required]
        [Column(nameof(Email))]
        public string Email { get; set; }

        [Required]
        [Column(nameof(AddressId))]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public AddressEntity Address { get; set; }

        [ForeignKey("ClientId")]
        public ICollection<DriverLicenseEntity> DriverLicenses { get; set; }

        [ForeignKey("ClientId")]
        public ICollection<TransportEntity> Transport { get; set; }
    }
}