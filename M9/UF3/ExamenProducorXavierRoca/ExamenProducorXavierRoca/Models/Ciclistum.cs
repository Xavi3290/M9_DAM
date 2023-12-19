using System;
using System.Collections.Generic;

namespace ExamenProducorXavierRoca.Models;

public partial class Ciclistum
{
    public short Dorsal { get; set; }

    public string Nombre { get; set; } = null!;

    public short? Edad { get; set; }

    public string Nomeq { get; set; } = null!;

    public virtual ICollection<Etapa> Etapas { get; } = new List<Etapa>();

    public virtual ICollection<Llevar> Llevars { get; } = new List<Llevar>();

    public virtual Equipo NomeqNavigation { get; set; } = null!;

    public virtual ICollection<Puerto> Puertos { get; } = new List<Puerto>();
}
