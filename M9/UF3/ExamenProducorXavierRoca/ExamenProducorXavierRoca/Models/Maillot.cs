using System;
using System.Collections.Generic;

namespace ExamenProducorXavierRoca.Models;

public partial class Maillot
{
    public string Codigo { get; set; } = null!;

    public string? Tipo { get; set; }

    public string? Color { get; set; }

    public int? Premio { get; set; }

    public virtual ICollection<Llevar> Llevars { get; } = new List<Llevar>();
}
