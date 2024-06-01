using System;
using System.Collections.Generic;

namespace Almacen_.Models;

public partial class Entradum
{
    public string EntradaId { get; set; } = null!;

    public int EntradaCantidad { get; set; }

    public DateTime EntradaFecha { get; set; }
}
