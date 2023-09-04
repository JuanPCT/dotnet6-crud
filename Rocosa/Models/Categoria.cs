using System.ComponentModel.DataAnnotations;

namespace Rocosa.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre de Categoria es Obligatorio")]
        public string? NombreCategoria { get; set; }

        [Required(ErrorMessage ="Orden es Obligatorio")]
        [Range(1, int.MaxValue ,ErrorMessage ="El Orden debe ser mayor a 0")]
        public int MostrarOrden { get; set; }

    }
}
