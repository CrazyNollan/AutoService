using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("Inspections")]
    public class InspectionEntity
    {
        [Required]
        [Column(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Number))]
        public string Number { get; set; }

        [Required]
        [Column(nameof(StartYear))]
        public int StartYear { get; set; }

        [Required]
        [Column(nameof(ExpireYear))]
        public int ExpireYear { get; set; }

        [Required]
        [Column(nameof(IsPassed))]
        public bool IsPassed { get; set; }

        [Required]
        [Column(nameof(TransportId))]
        public int TransportId { get; set; }

        [ForeignKey(nameof(TransportId))]
        public TransportEntity Transport { get; set; }
    }
}