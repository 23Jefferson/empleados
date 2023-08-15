using System;

namespace RegistroEmpleadosConstructora
{
    class Empleado
    {
        public string NombreCompleto { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public double SalarioPorHora { get; set; }
        public int HorasTrabajadas { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[5];

            Console.WriteLine("Registro de Empleados de Constructora");
            Console.WriteLine("=====================================");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Empleado {i + 1}");

                empleados[i] = RegistrarEmpleado();

                Console.WriteLine();
            }

            Console.WriteLine("Datos de los Empleados Registrados");
            Console.WriteLine("=================================");

            foreach (Empleado empleado in empleados)
            {
                MostrarEmpleado(empleado);
                Console.WriteLine();
            }
        }

        static Empleado RegistrarEmpleado()
        {
            Empleado empleado = new Empleado();

            Console.Write("Nombre completo: ");
            empleado.NombreCompleto = Console.ReadLine();

            Console.Write("DUI: ");
            empleado.DUI = Console.ReadLine();

            Console.Write("NIT: ");
            empleado.NIT = Console.ReadLine();

            Console.Write("Salario por hora: ");
            empleado.SalarioPorHora = double.Parse(Console.ReadLine());

            Console.Write("Horas trabajadas: ");
            empleado.HorasTrabajadas = int.Parse(Console.ReadLine());

            return empleado;
        }

        static void MostrarEmpleado(Empleado empleado)
        {
            Console.WriteLine("Nombre completo: " + empleado.NombreCompleto);
            Console.WriteLine("DUI: " + empleado.DUI);
            Console.WriteLine("NIT: " + empleado.NIT);
            Console.WriteLine("Salario por hora: " + empleado.SalarioPorHora);
            Console.WriteLine("Horas trabajadas: " + empleado.HorasTrabajadas);
        }
    }
}