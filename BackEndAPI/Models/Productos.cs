using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackEndAPI.Models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Ubicacion { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Precio { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Descripcion { get; set; }
    }
}
