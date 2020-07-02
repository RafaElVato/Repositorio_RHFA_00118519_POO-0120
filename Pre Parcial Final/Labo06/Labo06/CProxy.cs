using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLabo06
{
    public class CProxy
    {
        public interface IUsuario
        {
            void peticion(int choose);
        }

        public class SecurityProxy : IUsuario
        {

            public void peticion(int choose)
            {
                string contra;

                if (choose == 1)
                {
                    Console.WriteLine("Escribe la contraseña: ");
                    contra = Console.ReadLine();

                    if (contra == "pooProxy")
                    {
                        List<Evaluacion> ev = new List<Evaluacion>();
                        int opc;
                        string types;
                        string names;
                        int nota = 0;
                        string names2;
                        int nota2 = 0;
                        int preguntas;
                        string names3;
                        int nota3 = 0;
                        string date;
                        int totalProm;

                        do
                        {
                            Console.WriteLine("\nEvaluador de Notas.");
                            Console.WriteLine("1) Agregar evaluación");
                            Console.WriteLine("2) Mostrar las evaluaciones almacenadas");
                            Console.WriteLine("3) Eliminar evaluación");
                            Console.WriteLine("4) Salir del programa");
                            Console.WriteLine("Opcion a escoger: ");
                            opc = Convert.ToInt32(Console.ReadLine());

                            switch (opc)
                            {
                                case 1:
                                    Console.Write("Tipo de evaluacion a ingresar: ");
                                    types = Console.ReadLine();
                                    if (types == "Laboratorio" || types == "laboratorio" || types == "LABORATORIO")
                                    {
                                        Console.Write("Nombre del laboratorio: ");
                                        names = Console.ReadLine();
                                        Console.Write("Porcentaje del laboratorio (no debe exceder el 100%): ");
                                        nota = Convert.ToInt16(Console.ReadLine());
                                        if (nota > 100)
                                        {
                                            Console.WriteLine("No se puede ingresar un porcentaje mayor a 100");
                                        }

                                        ev.Add(new Laboratorio(nota, names, types));
                                    }

                                    else if (types == "Parcial" || types == "parcial" || types == "PARCIAL")
                                    {
                                        Console.Write("Nombre del parcial: ");
                                        names2 = Console.ReadLine();
                                        Console.WriteLine("Porcentaje del parcial (no debe exceder el 100%): ");
                                        nota2 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Cantidad de preguntas que tendra: ");
                                        preguntas = Convert.ToInt16(Console.ReadLine());
                                        ev.Add(new Parcial(nota2, names2, preguntas));
                                    }
                                    else if (types == "Tarea" || types == "tarea" || types == "TAREA")
                                    {
                                        Console.WriteLine("Nombre de la tarea: ");
                                        names3 = Console.ReadLine();
                                        Console.WriteLine("Procentaje de la tarea: ");
                                        nota3 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Fecha de entrega (año/mes/dia): ");
                                        date = Console.ReadLine();
                                        var fecha = DateTime.Parse(date);
                                        ev.Add(new Tarea(nota3, names3, fecha));
                                    }

                                    totalProm = nota + nota2 + nota3;

                                    if (totalProm > 100)
                                    {
                                        Console.WriteLine("No puedes ingresar más evaluaciones");
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("Mostrando todas las evaluaciones");

                                    Console.WriteLine("Las evaluaciones añadidas son: ");

                                    foreach (var Evaluation in ev)
                                    {
                                        Console.Write("\nNombre: " + Evaluation.Nombre + "\nPorcentaje de la evaluacion: "
                                                      + Evaluation.Porcentaje + "\n");
                                    }
                                    if (ev == null)
                                    {
                                        Console.WriteLine("Error!!");
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Evaluación a eliminar: ");
                                    String eliminar = Console.ReadLine();
                                    foreach (var evaluacion in ev)
                                    {
                                        if (evaluacion.Nombre == eliminar)
                                        {
                                            Console.WriteLine("\n" + evaluacion.ToString());
                                        }
                                    }

                                    ev.RemoveAll(evaluacion => evaluacion.Nombre == eliminar);
                                    Console.WriteLine("La evaluacion se ha eliminado exitosamente");
                                    break;

                                case 4:
                                    double muestraFinal = CalcularNota.Calcular(ev);
                                    if (muestraFinal <= 100)
                                    {
                                        Console.WriteLine("Promedio final de las notas: " + muestraFinal);
                                        if (muestraFinal > 60)
                                        {
                                            Console.WriteLine("Felicidades, a pasado satisfactoriamente la materia :D/");
                                        }
                                        else if (muestraFinal < 60)
                                        {
                                            Console.WriteLine("Lo lamento, no has pasado la materia :,v");
                                        }
                                    }

                                    opc = 6;
                                    break;
                            }
                        } while (opc != 6);
                    }
                    else
                    {
                        Console.WriteLine("La contraseña es incorrecta, vuelva a intentarlo\n");
                        Console.WriteLine("-----------------------------------------------------");
                    }

                }
            }


        }


    }
}
