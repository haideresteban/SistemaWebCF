using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebCF.Models
{
    public class Categoria
    {
        public int idcategoria { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre no debe tener mas de 50 caracteres, ni menos de 3.")]
        [Display(Name ="Nombre")]
        public string nombre { get; set; }

        [StringLength(255, ErrorMessage = "La descripcion no debe tener mas de 255 caracteres")]
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
        [Display(Name = "Estado")]
        public bool? estado { get; set; }
        public virtual ICollection<Producto> productos { get; set; }

    }
}
