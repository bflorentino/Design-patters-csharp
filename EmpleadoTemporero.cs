using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_APP
{
    class EmpleadoTemporero: IEmpleado
    {
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }

        private readonly int horasDeTrabajo = 8;
        public int HorasDeTrabajo{
            get{
                return horasDeTrabajo;
            }
        }

        private readonly int metodoPago = 2;
        public int MetodoPago{
            get{
                return metodoPago;
            }
        }

        public double PrecioPorHora { get; set; }

        public EmpleadoTemporero(string nombre, string departamento, string cargo, double precioHora){
            
            Nombre = nombre;
            Departamento = departamento;
            Cargo = cargo;
            PrecioPorHora = precioHora;      
        }

        public double CalcularSueldo(){
             
            double sueldo = (horasDeTrabajo * PrecioPorHora) * 23.8;
            return sueldo;
        }

        public void CobrarSueldo() {

            Console.WriteLine("El empleado temporero {0} ha cobrado su sueldo mediante un cheque", Nombre);

        }
    }    
}