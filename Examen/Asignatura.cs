using System;
namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalculoNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalculoNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public string MsjNotaFinal(double notaFinal)
        {
            if (notaFinal >= 90)
            {
                return "Sobresaliente";
            }
            else if (notaFinal >= 80)
            {
                return "Muy Bueno";
            }
            else if (notaFinal >= 60)
            {
                return "Bueno";
            }
            else
            {
                return "Reprobado";
            }
        }

        public void Imprimir()
        {
            double notaFinal = CalculoNotaFinal();
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}\nNumero de Cuenta: {NumeroCuenta}\nCorreo electronico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}\nHorario: {Horario}\nNombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota final: {notaFinal}% - {MsjNotaFinal(notaFinal)}");

            double notaFinalParam = CalculoNotaFinal(N1, N2, N3);
            Console.WriteLine($"Nota final: {notaFinalParam}% - {MsjNotaFinal(notaFinalParam)}");
        }
    }

}

