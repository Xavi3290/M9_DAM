using System;
using System.Collections.Generic;

namespace ExamenProducorXavierRoca.Models;

public partial class Puerto
{
    public string Nompuerto { get; set; } = null!;

    public short? Altura { get; set; }

    public string? Categoria { get; set; }

    public double? Pendiente { get; set; }

    public short Netapa { get; set; }

    public short Dorsal { get; set; }

    public virtual Ciclistum DorsalNavigation { get; set; } = null!;

    public virtual Etapa NetapaNavigation { get; set; } = null!;
}
