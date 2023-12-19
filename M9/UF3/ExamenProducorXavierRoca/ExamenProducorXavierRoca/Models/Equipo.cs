using System;
using System.Collections.Generic;

namespace ExamenProducorXavierRoca.Models;

public partial class Equipo
{
    public string Nomeq { get; set; } = null!;

    public string? Director { get; set; }

    public virtual ICollection<Ciclistum> Ciclista { get; } = new List<Ciclistum>();
}
