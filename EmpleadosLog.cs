using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RRHH_APP
{
    class EmpleadosLog
    {
        // IMPLEMENTACIÓN DEL PATRON DE DISEÑO SINGLETON 

        private static EmpleadosLog empleadosLog = null;

        private EmpleadosLog() { }

        public static EmpleadosLog GetLog()
        {
            if (empleadosLog == null) {
                empleadosLog = new EmpleadosLog();
            }
            return empleadosLog;
        }

        public bool AddEmpleado(IEmpleado empleado)
        {
        // AÑADE A UN EMPLEADO AL ARCHIVO LOG CON LOS EMPLEADOS CREADOS
            try
            {
                string archivoLog = GetArchivo();

                string fechaCreacion = DateTime.Now.ToString("d/MM/yyyy");
                string horaCreacion = DateTime.Now.ToString("hh:mm:ss tt");

                StreamWriter agregarEmpleado = File.AppendText(archivoLog);

                agregarEmpleado.WriteLine("\nNuevo Empleado\n");

                agregarEmpleado.WriteLine("Fecha de creación {0}", fechaCreacion);
                agregarEmpleado.WriteLine("Hora de creación {0}", horaCreacion);
                agregarEmpleado.WriteLine("Nombre: {0}", empleado.Nombre);
                agregarEmpleado.WriteLine("Departamento: {0}", empleado.Departamento);
                agregarEmpleado.WriteLine("Cargo: {0}", empleado.Cargo);
                agregarEmpleado.WriteLine("Salario: {0}", empleado.CalcularSueldo());

                agregarEmpleado.Close();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private string GetArchivo()
        {
         // COMPRUEBA SI EXISTE UN ARCHIVO CON EL SIGUIENTE NOMBRE SI NO EXISTE, LO CREA Y LO RETORNA, DE LO CONTRARIO SOLO RETORNA EL STRING
            string archivo = "empleadosLog.txt";

           if (File.Exists(archivo) == false) {

               File.Create(archivo).Close();

            }
            return archivo; 
        }
    }
}