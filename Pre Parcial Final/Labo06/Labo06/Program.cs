using System;
using System.Collections.Generic;

namespace ProxyLabo06
{
  internal class Program
  {
        public static void Main(string[] args)
        {

            CProxy.IUsuario privadoProxy = new CProxy.SecurityProxy();
            int Escogio;

            do
            {
                    Console.WriteLine("Selecciona que quieres hacer: ");
                    Console.WriteLine("1) Ingresar en 'Registro de notas'\n");
                    Console.WriteLine("2) Salir del programa\n");
                    Console.WriteLine("Opcion a escoger: ");
                    Escogio = Convert.ToInt32(Console.ReadLine());

                    switch (Escogio)
                    {
                        //Contraseña es: pooProxy
                        case 1: privadoProxy.peticion(1); break;

                        default: Console.WriteLine("Error!"); break;
                    }
                
            } while (Escogio != 2);
        }
  }

}
