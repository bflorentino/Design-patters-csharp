using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_APP
{
    class EmpleadoTiempoCompleto: IEmpleado
    {
        public string Nombre { get; set; }

        public string Departamento { get; set; }

        public string Cargo { get; set; }

        private readonly int horasDeTrabajo = 8;
        public int HorasDeTrabajo{
            get
            {
                return horasDeTrabajo;
            }
        }

        public double PrecioPorHora { get; set; }

        public string NumeroCuenta { get; set; }

        private readonly int metodoPago = 1;

        public int MetodoPago{
            get
            {
                return metodoPago;
            }
        }

        public EmpleadoTiempoCompleto(string nombre, string numeroCuenta,  string cargo, string departamento, double precioPorHora)
        {
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            Cargo = cargo;
            Departamento = departamento;
            PrecioPorHora = precioPorHora;
        }

        public double CalcularSueldo(){

            double sueldo = (horasDeTrabajo * PrecioPorHora) * 23.8;
            return sueldo;
        }

        public void CobrarSueldo() {

            Console.WriteLine("El empleado de tiempo completo {0} ha cobrado su sueldo mediante su cuenta bancaria {1}", Nombre, NumeroCuenta);

        }
    }
}