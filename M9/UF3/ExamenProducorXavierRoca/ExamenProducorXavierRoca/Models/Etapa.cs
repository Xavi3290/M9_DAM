using System;
using System.Collections.Generic;

namespace ExamenProducorXavierRoca.Models;

public partial class Etapa
{
    public short Netapa { get; set; }

    public short? Km { get; set; }

    public string? Salida { get; set; }

    public string? Llegada { get; set; }

    public short Dorsal { get; set; }

    public virtual Ciclistum DorsalNavigation { get; set; } = null!;

    public virtual ICollection<Llevar> Llevars { get; } = new List<Llevar>();

    public virtual ICollection<Puerto> Puertos { get; } = new List<Puerto>();
}
