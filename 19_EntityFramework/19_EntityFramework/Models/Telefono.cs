using System;
using System.Collections.Generic;

namespace _19_EntityFramework.Models;

public partial class Telefono
{
    public long TelefonoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Telefono1 { get; set; } = null!;
}
