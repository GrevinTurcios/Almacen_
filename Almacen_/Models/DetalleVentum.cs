using System;
using System.Collections.Generic;

namespace Almacen_.Models;

public partial class DetalleVentum
{
    public int DetalleVentaId { get; set; }

    public int VentaId { get; set; }

    public int ProductoId { get; set; }
}
