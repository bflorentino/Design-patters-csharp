using System;
using System.Collections.Generic;
using System.Text;

namespace RRHH_APP
{
    class EmpleadoFactory
    {

        // IMPLEMENTACIÓN DEL PATRON DE DISEÑO FACTORY
        public static IEmpleado CrearEmpleado() 
        {
            IEmpleado empleado = null;

            Console.WriteLine("Indique el nombre del empleado");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nIndique el departamento en que trabaja");
            string departamento = Console.ReadLine();

            Console.WriteLine("\nIndique el cargo que ostentará el empleado");
            string cargo = Console.ReadLine();

            Console.WriteLine("\nIndique la cantidad de horas que trabajara. Seleccione 1 o 2.\n\n1) 8 horas\n2) 4 horas");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIndique el precio por hora");
            double precioHora = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIndique el método de pago. Seleccione 1 o 2.\n\n1) Cuenta bancaria\n2) Cheque");
            int metodoPago = int.Parse(Console.ReadLine());

            if (horas == 1 && metodoPago == 1)
            {
                string numeroCuenta = PedirNumeroDeCuenta();
                empleado = new EmpleadoTiempoCompleto(nombre, numeroCuenta, cargo, departamento, precioHora);
            }

            else if (horas == 1 && metodoPago == 2)
            {
                empleado = new EmpleadoTemporero(nombre, departamento, cargo, precioHora); 
            }

            else if(horas == 2 && metodoPago == 1)
            {
                string numeroCuenta = PedirNumeroDeCuenta();
                empleado = new EmpleadoMedioTiempo(nombre, numeroCuenta, cargo, departamento, precioHora);
            }

            else
            {
                Console.WriteLine("\nNo se pudo crear un empleado con esas especificaciones. El empleado es Nulo");
            }

            return empleado;
        }



        private static string PedirNumeroDeCuenta()
        {
            Console.WriteLine("\nIndique el número de cuenta");
            string numeroCuenta = Console.ReadLine();
            return numeroCuenta;
        }
    }
}
