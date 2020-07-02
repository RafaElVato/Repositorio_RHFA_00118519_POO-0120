using System;
using System.Collections.Generic;

namespace ProxyLabo06
{
    public static class CalcularNota
    {
        public static double Calcular(List<Evaluacion> ev)
        {
            double nota, promedioFinal = 0;

            foreach (var Promedio in ev)
            {
                Console.WriteLine("Nota que obtuvo el estudiante: ");
                nota = Convert.ToDouble(Console.ReadLine());
                promedioFinal += nota * (Promedio.Porcentaje/100.00);
            }
            
            
            return promedioFinal;
            
        }


    }
}