using System;
using Examen;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.Write("Ingrese nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();
            Console.Write("Ingrese numero de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();
            Console.Write("Ingrese correo electronico: ");
            asignatura.Email = Console.ReadLine();
            Console.Write("Ingrese nombre de la clase: ");
            asignatura.NombreAsignatura = Console.ReadLine();
            Console.Write("Ingrese horario de la clase: ");
            asignatura.Horario = Console.ReadLine();
            Console.Write("Ingrese nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.Write("Ingrese nota del primer parcial (Max. 30 puntos): ");
            asignatura.N1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nota del segundo parcial (Max. 30 puntos): ");
            asignatura.N2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nota del tercer parcial (Max. 40 puntos): ");
            asignatura.N3 = int.Parse(Console.ReadLine());

            if (asignatura.N1 <= 30 && asignatura.N2 <= 30 && asignatura.N3 <= 40)
            {
                Console.WriteLine();
                Console.WriteLine("*************** Resultado ***************");
                asignatura.Imprimir();
                Console.WriteLine("*****************************************");
                Console.ReadLine();
            }
            else if (asignatura.N1 > 30 || asignatura.N2 > 30)
            {
                Console.Write("La nota del primer o segundo parcial sobrepasa del 30%");
                Console.ReadLine();
            }
            else if (asignatura.N3 > 40)
            {
                Console.Write("La nota del tercer parcial sobrepasa del 40%");
                Console.ReadLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("*************** Error ***************");
            Console.WriteLine($"Error: {ex.Message}");
            Console.ReadLine();
        }
    }
}
