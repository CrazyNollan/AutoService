using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("Transport")]
    public class TransportEntity
    {
        [Required]
        [Column(nameof(Id))]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Number))]
        public string Number { get; set; }

        [Required]
        [Column(nameof(TransportMakeId))]
        public int TransportMakeId { get; set; }

        [ForeignKey(nameof(TransportMakeId))]
        public TransportMakeEntity Make { get; set; }

        [Required]
        [Column(nameof(TransportModelId))]
        public int TransportModelId { get; set; }

        [ForeignKey(nameof(TransportModelId))]
        public TransportModelEntity Model { get; set; }

        [Required]
        [Column(nameof(FuelId))]
        public int FuelId { get; set; }

        [ForeignKey(nameof(FuelId))]
        public FuelEntity Fuel { get; set; }

        [Required]
        [Column(nameof(TransportCategoryId))]
        public int TransportCategoryId { get; set; }

        [ForeignKey(nameof(TransportCategoryId))]
        public TransportCategoryEntity Category { get; set; }

        [Required]
        [Column(nameof(ClientId))]
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public ClientEntity Client { get; set; }

        [ForeignKey("TransportId")]
        public ICollection<InspectionEntity> Inspections { get; set; }
    }
}