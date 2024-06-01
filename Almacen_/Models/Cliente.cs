using System;
using System.Collections.Generic;

namespace Almacen_.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string ClienteNombre { get; set; } = null!;

    public string ClienteApellido { get; set; } = null!;

    public string ClienteCorreo { get; set; } = null!;

    public int ClienteTelefono { get; set; }

    public string ClienteDireccion { get; set; } = null!;
}
