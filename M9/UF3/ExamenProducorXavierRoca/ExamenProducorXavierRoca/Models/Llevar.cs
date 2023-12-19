using System;
using System.Collections.Generic;

namespace ExamenProducorXavierRoca.Models;

public partial class Llevar
{
    public short Dorsal { get; set; }

    public short Netapa { get; set; }

    public string Codigo { get; set; } = null!;

    public virtual Maillot CodigoNavigation { get; set; } = null!;

    public virtual Ciclistum DorsalNavigation { get; set; } = null!;

    public virtual Etapa NetapaNavigation { get; set; } = null!;
}
