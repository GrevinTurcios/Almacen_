using System;
using System.Collections.Generic;

namespace Almacen_.Models;

public partial class Categorium
{
    public int CategoriaId { get; set; }

    public string CategoriaNombre { get; set; } = null!;

    public string CategoriaDescripcion { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
