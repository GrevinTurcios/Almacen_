using System;
using System.Collections.Generic;

namespace Almacen_.Models;

public partial class PuestoUsuario
{
    public int PuestoId { get; set; }

    public string PuestoNombre { get; set; } = null!;

    public string PuestoDescripcion { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
