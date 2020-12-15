
using System.ComponentModel.DataAnnotations;

namespace SistemaWebCF.Models
{
    public class Producto
    {
        public int idproducto { get; set; }

        [Required(ErrorMessage ="Selceccion una categoria")]
        public int idcategoria { get; set; }

        [StringLength(64, ErrorMessage = "La codigo no debe tener mas de 64 caracteres")]
        public string codigo { get; set; }

        [Required (ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre no debe tener mas de 100 caracteres, ni menos de 3.")]
        public string nombre { get; set; }

        [Required]
        public decimal? precio_venta { get; set; }

        [Required]
        public int stok { get; set; }

        [StringLength(255, ErrorMessage = "La descripcion no debe tener mas de 255 caracteres")]
        public string descripcion { get; set; }
        public bool? estado { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
