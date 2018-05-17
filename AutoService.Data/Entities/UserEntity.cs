using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService.Data.Entities
{
    [Table("Users")]
    public class UserEntity
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
        [Column(nameof(TokenNumber))]
        public int TokenNumber { get; set; }

        [Required]
        [Column(nameof(Login))]
        public string Login { get; set; }

        [Required]
        [Column(nameof(Password))]
        public string Password { get; set; }
    }
}