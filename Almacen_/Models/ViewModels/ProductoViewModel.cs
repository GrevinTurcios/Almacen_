using System.ComponentModel.DataAnnotations;

namespace Almacen_.Models.ViewModels
{
    public class ProductoViewModel
    {
        [Required]
        [Display(Name = "ID")]
        public int Categoria_ID { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Categoria_Nombre { get; set; }
        

    }
}
