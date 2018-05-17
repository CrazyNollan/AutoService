using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("DriverLicenses")]
    public class DriverLicenseEntity
    {
        [Required]
        [Column(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Number))]
        public string Number { get; set; }

        [Required]
        [Column(nameof(Year))]
        public int Year { get; set; }

        [Required]
        [Column(nameof(Month))]
        public int Month { get; set; }

        [Required]
        [Column(nameof(Day))]
        public int Day { get; set; }

        [Required]
        [Column(nameof(TransportCategoryId))]
        public int TransportCategoryId { get; set; }

        [ForeignKey(nameof(TransportCategoryId))]
        public TransportCategoryEntity TransportCategory { get; set; }

        [Required]
        [Column(nameof(ClientId))]
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public ClientEntity Client { get; set; }
    }
}