    using System;
using System.Collections.Generic;

namespace Almacen_.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string ProductoNombre { get; set; } = null!;

    public string ProductoDescripcion { get; set; } = null!;

    public int ProductoPrecio { get; set; }

    public byte[]? ProductoImagen { get; set; }
}
