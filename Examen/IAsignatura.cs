using System;
namespace Examen
{
	public interface IAsignatura
	{
        double CalculoNotaFinal(); 
        double CalculoNotaFinal(int n1, int n2, int n3);
        string MsjNotaFinal(double notaFinal);
        void Imprimir();
    }
}

