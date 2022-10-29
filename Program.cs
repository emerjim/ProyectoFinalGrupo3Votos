/*
Sección A - Algoritmos - Grupo #3.

Nombres:                                # de Carnet:
Emerson Alejandro Jiménez Torres        9989-21-20811
Hugo Alexander Domínguez Castellanos    9989-16-12969
Marco Antonio Rodriguez Aguirre         9989-19-63
Gerson Fernando Ixtecoc Pérez           9989-22-3276
Elvin Eduardo Muralles Melgar           9989-22-5053
Jorge David Gatica García               9989-22-128
*/

using System;

public class Program
{

          public static void Main (string[] args)
          {

          //Bienvenida al programa y detalle de lo que hará.
          Console.WriteLine("Bienvenido al Sistema de Votación - GRUPO #3");
          Console.WriteLine("---------------------------------------------");
          Console.WriteLine("El programa realizará lo siguiente: ");
          Console.WriteLine("El sistema cargará los datos y partidos políticos que definiremos nosotros por teclado, ");
          Console.WriteLine("cada candidato tendrá un identificador númerico.");
          Console.WriteLine("Se definirá un ganador basado en una lista de votos (precargada) que ya hemos definido previamente. ");
          Console.WriteLine("El sistema imprimirá el resultado de la votación.");
          Console.WriteLine("");
        
          
          //Declaracion de variables y arreglos
          double temporal;
          double contador, acumulado;
          string candidatos;
          int opc, size, j, indiceSiguiente;
          
          //Creacion de los arreglos
          double[] lista = null;
          double[] listaVotos = null;
          double[] totalVotos = null;
          double[] porcentaje = null;
          double[] resultadoPorcentaje = null;
          int[] posicionFinal = null;
          string[] nombreCandidato = null;
          string[] partidoCandidato = null;


          
          Console.WriteLine("Presiona una tecla para desplegar el menú:");
          Console.ReadKey();


          do {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("««« Elecciones Generales Presidenciales de Guatemala 2023 »»»");
                    Console.WriteLine("_____________________________________________________________");
                    Console.WriteLine("*** SISTEMA DE VOTACIÓN - GRUPO #3 ***");
                    Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                    Console.WriteLine("1. Definir los candidatos");
                    Console.WriteLine("2. Generación de la lista de votos");
                    Console.WriteLine("3. Cálculo de los votos");
                    Console.WriteLine("4. Impresión de los resultados");
                    Console.WriteLine("5. SALIR");
                    
                    opc= Convert.ToInt32(Console.ReadLine());


                    //Menú por medio del Switch Case
                    switch(opc)
                    {
                    case 1:
                              Console.WriteLine("Usted seleccionó la opcion 1. Definir los candidatos");
                              Console.WriteLine("Por favor, introduzca la cantidad de candidatos");
                              candidatos = Convert.ToString(Console.ReadLine());

                              size = Int32.Parse(candidatos);
                              

                              //Dimensión de los arreglos Unidimensionales
                              lista = new double[size];
                              nombreCandidato = new string[size];
                              partidoCandidato = new string[size];

                              Console.WriteLine("Usted ha seleccionado: "+candidatos+" candidatos.");

                              for (int i = 0; i < size; i++) //para gaurdar los datos.
                              {
                                        lista[i] = (i+1);
                                        
                                        Console.WriteLine("Introduzca el nombre del candidato #"+(i+1)+":");
                                        nombreCandidato[i] = Convert.ToString(Console.ReadLine());


                                        Console.WriteLine("Introduzca el partido político del candidato #"+(i+1)+":");
                                        partidoCandidato[i] = Convert.ToString(Console.ReadLine());
                                        Console.WriteLine("");

                              }

                              Console.WriteLine("");
                              Console.WriteLine("Listo, los candidatos y partidos políticos fueron cargados correctamente....");
                              Console.WriteLine("");
                              //Tomar captura de pantalla para comprobar los resultados finales
                              Console.WriteLine("___________________________________________________________");
                              Console.WriteLine("A continuación se muestra el listado de datos introducidos: ");
                              Console.WriteLine("");

                              for (int i = 0; i < size; i++) //para imprimir los datos guardados.
                              {
//                                        Console.WriteLine("Aqui i es> "+i);
                                        Console.WriteLine("Candidato #"+lista[i]+", nombre: "+nombreCandidato[i]+", y el partido politico es: "+partidoCandidato[i]);
                              }

                              break;
                    case 2:
                              Console.WriteLine("");
                              Console.WriteLine("Usted ha seleccionado la opción 2. Generacion de la lista de votos");
                              Console.WriteLine("");
                              Console.WriteLine("La lista de votos es la siguiente: ");
                              Console.WriteLine("");

                              listaVotos = new double[30];

                              listaVotos[0] = 3;
                              listaVotos[1] = 3;
                              listaVotos[2] = 3;
                              listaVotos[3] = 2;
                              listaVotos[4] = 1;
                              listaVotos[5] = 4;
                              listaVotos[6] = 1;
                              listaVotos[7] = 3;
                              listaVotos[8] = 2;
                              listaVotos[9] = 1;
                              listaVotos[10] = 5;
                              listaVotos[11] = 2;
                              listaVotos[12] = 3;
                              listaVotos[13] = 2;
                              listaVotos[14] = 5;
                              listaVotos[15] = 5;
                              listaVotos[16] = 1;
                              listaVotos[17] = 5;
                              listaVotos[18] = 2;
                              listaVotos[19] = 2;
                              listaVotos[20] = 2;
                              listaVotos[21] = 3;
                              listaVotos[22] = 3;
                              listaVotos[23] = 2;
                              listaVotos[24] = 1;
                              listaVotos[25] = 5;
                              listaVotos[26] = 1;
                              listaVotos[27] = 4;
                              listaVotos[28] = 2;
                              listaVotos[29] = 0;

                              

                              for (int i = 0; i <= listaVotos.Length-1; i++) //para imprimir los datos guardados.
                              {
                                        Console.WriteLine("ListaVotos ["+i+"] es = "+listaVotos[i]);
                              }

                              Console.WriteLine("");

                              Console.WriteLine("Esta es la lista de los candidatos: ");
                              for (int i = 0; i < lista.Length; i++) //para imprimir los datos guardados lista.
                              {
                                        Console.WriteLine("Lista Candidatos lista["+i+"] es = "+lista[i]);
                              }

                              break;
                    case 3:
                              Console.WriteLine("");
                              Console.WriteLine("Usted ha seleccionado la opción 3. Cálculo de los votos.");
                              Console.WriteLine("");
                              
                              int size2 = lista.Length;
                              
                              totalVotos = new double[size2];

                              for (int i = 0; i < lista.Length; i++) //para inicializar en 0 votos a cada candidato.
                              {
                                        totalVotos[i] = 0;
                              }

                              //SE UTILIZO SOLO PARA COMPROBAR QUE LOS TOTALES ESTUVIERAN A CERO...
                              // Console.WriteLine("Prueba de que los totalVotos estan a 0: ");
                              // for (int i = 0; i < lista.Length; i++) //para inicializar en 0 votos a cada candidato.
                              // {
                              //           Console.WriteLine("El total ["+i+"] es: "+totalVotos[i]);
                              // }


                              contador = 0;
                              acumulado = 0;

                              for (int i = 0; i < listaVotos.Length; i++) //para realizar la sumatoria de votos.
                              {
                                        if(listaVotos[i] == 0)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Proceso de contabilización de votos y cálculo finalizado... ");      
                                        }
                                        else
                                        {
                                             for (j = 0; j < totalVotos.Length; j++) //para inicializar en 0 votos a cada candidato.
                                                  {
                                                            if(listaVotos[i] == lista[j])
                                                            {
                                                            contador = 1;
                                                            acumulado = totalVotos[j]+contador;
                                                            totalVotos[j] = acumulado;

                                                            }
                                                  }     
                                        }
                              }

                              Console.WriteLine("");
                              Console.WriteLine("");
                              Console.WriteLine("El resultado es el siguiente: ");
                              for (int i = 0; i < totalVotos.Length; i++) //para imprimir los datos guardados.
                              {
                                        Console.WriteLine("TotalVotos ["+i+"] es = "+totalVotos[i]);
                              }


                              //Cálculo del Porcentaje
                              porcentaje = new double[size2];
                              resultadoPorcentaje = new double[size2]; 
                              posicionFinal = new int[size2]; 

                              int votosValidos = (listaVotos.Length-1);
                            Console.ForegroundColor = ConsoleColor.Blue;
                              Console.WriteLine("");
                              Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                              Console.WriteLine("El resumen de votos es el siguiente: ");
                              Console.WriteLine("");


                              for (int i = 0; i < lista.Length; i++) //para imprimir los datos guardados.
                              {
                                        if(totalVotos[i] == 0)
                                        {
                                                 Console.WriteLine("Total votos para el candidato #"+i+", es: "+totalVotos[i]+", que representan el: 0%"); 
                                        }
                                        else
                                        {
                                                  
                                                  porcentaje[i] = Convert.ToDouble((totalVotos[i]/votosValidos)*100);
                                                  resultadoPorcentaje[i] = porcentaje[i];
                                                  Console.WriteLine("Total votos para el candidato #"+(i+1)+", es: "+totalVotos[i]+", y el resultado es = "+resultadoPorcentaje[i]+" %");
                                        }
                              }

                              
                              break;
                    case 4:
                              Console.WriteLine("");
                              Console.WriteLine("Usted ha seleccionado la opción 4. Impresión de los resultados.");

                              //Aplicacion de metodo Burbuja

                              for (int i = 0; i < lista.Length; i++) //para imprimir los datos guardados.
                              {
                                        
                                        for (j = 0; j < lista.Length - 1; j++)
                                        {

                                                  indiceSiguiente = j + 1;

                                                  if(resultadoPorcentaje[j] < resultadoPorcentaje[indiceSiguiente])
                                                  {
                                                  //Console.WriteLine("Swapping");
                                                  temporal = resultadoPorcentaje[j];
                                                  resultadoPorcentaje[j] = resultadoPorcentaje[indiceSiguiente];
                                                  resultadoPorcentaje[indiceSiguiente] = temporal;
                                                  }
                                                  
                                        }
                              }

                              Console.WriteLine("");
                              //Para imprimir el resultado del Bubble sort listado descendente de los porcentajes

                              for (int i = 0; i < lista.Length; i++)
                              {
                                   Console.WriteLine("Este es el resultado de resultadoPorcentaje ["+i+"] = "+resultadoPorcentaje[i]);     
                              }

                              
                              // Para determinar el orden en el que se mostraran...
                              Console.WriteLine("");
                              Console.WriteLine("Aqui se determinará el orden en el que se mostraran.");
                              Console.WriteLine("");


                              for (int i = 0; i < lista.Length; i++)
                              {

                                        for (j = 0; j < lista.Length; j++)
                                        {

                                                  if(resultadoPorcentaje[i] == porcentaje[j])
                                                  {
                                                            posicionFinal[i] = j;
                                                  }

                                        }                    
                                                  
                              }

                              

                              Console.WriteLine("Esta el la posición de los porcentajes...");
                              Console.WriteLine("");

                              for (int i = 0; i < lista.Length; i++)
                              {
                                   
                                   Console.WriteLine("Aqui i es: "+i+" por lo que la porcentaje[i] es: "+porcentaje[i]);
                                   
                              }

                              Console.WriteLine("");
                              Console.WriteLine("Esta el la posición de las posiciones Finales...");
                              for (int i = 0; i < lista.Length; i++)
                              {
                                   
                                   Console.WriteLine("Aqui i es: "+i+" por lo que la posicionFinal[i] es: "+posicionFinal[i]);
                                   
                              }


                              //POR ÚLTIMO LA IMPRESIÓN DE LOS RESULTADOS
                            Console.ForegroundColor = ConsoleColor.Yellow;
                              Console.WriteLine("");
                              Console.WriteLine("");
                              Console.WriteLine("_______________________________________________");
                              Console.WriteLine("");
                              Console.WriteLine("       ****** RESULTADOS FINALES *******");
                              Console.WriteLine("_______________________________________________");

                               Console.WriteLine("");
                              Console.WriteLine("Las posiciones son las siguientes: ");
                              Console.WriteLine("");

                              Console.ForegroundColor=ConsoleColor.Green;

                              for (int i = 0; i < lista.Length; i++)
                              {
                                   int orden = posicionFinal[i];
                                   Console.WriteLine("");
                                   
                                   Console.WriteLine("- Posición Final #"+(i+1)+" = "+nombreCandidato[orden]+" candidato #"+lista[orden]+" y su partido politico es: "+partidoCandidato[orden]+", con un total de: "+totalVotos[orden]+" votos equivalente a: "+porcentaje[orden]+" %.");     
                              }
                              break;
                    case 5:
                              Console.WriteLine("Saliendo... gracias por utilizar este programa.");
                              break;
                    default:
                              Console.WriteLine("La opción ingresada no es valida, selecciona una opción del menú:");
                              break;
                    }
                    Console.ReadKey();
          

          }while(opc != 5);


          Console.WriteLine("Hasta aquí llega el sistema de votación, hasta la próxima..." );

          }
          
}
