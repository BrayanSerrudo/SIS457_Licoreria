using System;
using System.Collections.Generic;

namespace WebLicoreria.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Documento { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }
}
