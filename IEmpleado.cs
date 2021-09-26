using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_APP
{
    public interface IEmpleado
    {
        // PROPIEDADES QUE TENDRAN TODAS LAS CLASES QUE IMPLEMENTEN IEmpleado
        string Nombre { get; set; }
        string Departamento { get; set; }
        string Cargo { get; set; }
        double PrecioPorHora { get; set; }
        int HorasDeTrabajo { get; }
        int MetodoPago { get; }

        // METODOS
        double CalcularSueldo();
        void CobrarSueldo();
    }
}
