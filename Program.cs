using System;

namespace RRHH_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmpleado empleado;
            EmpleadosLog log = EmpleadosLog.GetLog();
            empleado = EmpleadoFactory.CrearEmpleado();

            if (empleado != null){

                if(log.AddEmpleado(empleado)){
                
                    Console.WriteLine("\nEl empleado fue agregado exitosamente al archivo historial");
                }
                else
                {
                    Console.WriteLine("\nEl empleado no se pudo agregar al historial debido a un error");
                }
            }
            Console.ReadKey();
        }
    }
}
