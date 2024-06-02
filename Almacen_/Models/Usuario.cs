using System;
using System.Collections.Generic;

namespace Almacen_.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string UsuarioNombre { get; set; } = null!;

    public string UsuarioApellido { get; set; } = null!;

    public string UsuarioCorreo { get; set; } = null!;

    public int UsuarioTelefono { get; set; }

    public string UsuarioPassword { get; set; } = null!;

    public int PuestoId { get; set; }

    public virtual PuestoUsuario Puesto { get; set; } = null!;
}
