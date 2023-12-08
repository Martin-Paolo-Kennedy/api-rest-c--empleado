using System;
using System.Collections.Generic;

namespace Gestion_Farmacia_martin.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? NombreCom { get; set; }

    public int? IdDepartamento { get; set; }

    public int? Sueldo { get; set; }

    public DateTime? FechaContratacion { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }
}
