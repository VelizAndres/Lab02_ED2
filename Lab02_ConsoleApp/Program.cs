using System;


namespace Lab02_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Ingresa el tamaño del valor");
            int tam=    int.Parse(Console.ReadLine());
            Laboratorio2_ED2.TreeB<int> tree = new Laboratorio2_ED2.TreeB<int>();
            tree.CreateData(tam,4,GetNumber,Empty);
            Random ElRandom1 = new Random();
            for (int j = 0; j < tam; j++)
            {
                tree.InsertTreeB(ElRandom1.Next(0, 1000));
            }

            Console.WriteLine("Funciono");
            Console.ReadKey();
        }

        public static Func<string, int> GetNumber = delegate (string data)
        {
            return int.Parse(data);
        };
        public static Func<int> Empty = delegate ()
         {
             return 0;
         };


            //           public static void Header()
            //             {
            //                 Console.Clear();
            //                 string textToEnter = "--PRÁCTICA DE LABORATORIO #2 - ESTRUCTURA DE DATOS 2--";
            //                 string textToEnter2 = "----- Javier Andrés Morales González - 1210219 | Diego Andrés Véliz Arauz - 1230019 -----";
            //                 Console.ForegroundColor = ConsoleColor.Yellow;
            //                 Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            //                 Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
            //                 Console.WriteLine("\n");
            //                 Console.ResetColor();
            //             }
            //             public static void TitleOption1()
            //             {
            //                 string t = "--NÚMEROS AL AZAR--";
            //                 Console.ForegroundColor = ConsoleColor.Green;
            //                 Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (t.Length / 2)) + "}", t) + "\n");
            //                 Console.ResetColor();
            //             }
            //             public static void TitleOption2()
            //             {
            //                 string t = "--INGRESO MANUAL DE NÚMEROS--";
            //                 Console.ForegroundColor = ConsoleColor.Green;
            //                 Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (t.Length / 2)) + "}", t) + "\n");
            //                 Console.ResetColor();
            //             }
            //             public static void TitleTraversal(int n)
            //             {
            //                 switch (n)
            //                 {
            //                     case 1:
            //                         {
            //                             string t = "--PREORDER--";
            //                             Console.ForegroundColor = ConsoleColor.Cyan;
            //                             Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (t.Length / 2)) + "}", t) + "\n");
            //                             Console.ResetColor();
            //                         }
            //                         break;
            //                     case 2:
            //                         {
            //                             string t = "--INORDER--";
            //                             Console.ForegroundColor = ConsoleColor.Cyan;
            //                             Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (t.Length / 2)) + "}", t) + "\n");
            //                             Console.ResetColor();
            //                         }
            //                         break;
            //                     case 3:
            //                         {
            //                             string t = "--POSTORDER--";
            //                             Console.ForegroundColor = ConsoleColor.Cyan;
            //                             Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (t.Length / 2)) + "}", t) + "\n");
            //                             Console.ResetColor();
            //                         }
            //                         break;
            //                 }
            //             }

            //             public static void Menu()
            //             {
            //                 Console.WriteLine("Seleccione una opción:\n" + "\n1. Ingresar números al azar." + "\n2. Ingresar números manualmente." + "\n3. Salir del programa." + Environment.NewLine);
            //             }
            //             static void Main(string[] args)
            //             {
            //                 bool exit = false;
            //                 while (!exit)
            //                 {
            //                     try
            //                     {
            //                         Header();
            //                         Menu();
            //                         int option = Convert.ToInt32(Console.ReadLine());
            //                         switch (option)
            //                         {
            //                             case 1:
            //                                 {
            //                                     //Laboratorio1_ED2.MultiwayTree<int> RandomTree = new MultiwayTree<int>();
            //                                     bool a = true;
            //                                     while (a)
            //                                     {
            //                                         try
            //                                         {
            //                                             Header();
            //                                             TitleOption1();
            //                                             Console.WriteLine("Ingrese el grado del árbol B (debe ser mayor a 2):");
            //                                             int m = Convert.ToInt32(Console.ReadLine());
            //                                             if (m < 2)
            //                                             {
            //                                                 throw new FormatException();
            //                                             }
            //                                             //RandomTree.SetM(m);
            //                                             Header();
            //                                             TitleOption1();
            //                                             Console.WriteLine("Ingrese la cantidad de números al azar a ingresar (debe ser mayor a 0):");
            //                                             int i = Convert.ToInt32(Console.ReadLine());
            //                                             if (i < 1)
            //                                             {
            //                                                 throw new FormatException();
            //                                             }
            //                                             Header();
            //                                             TitleOption1();
            //                                             Console.WriteLine("Ingrese el número mínimo generado al azar:");
            //                                             int min = Convert.ToInt32(Console.ReadLine());
            //                                             Header();
            //                                             TitleOption1();
            //                                             Console.WriteLine("Ingrese el número máximo generado al azar:");
            //                                             int max = Convert.ToInt32(Console.ReadLine());
            //                                             if (min > max || min == max)
            //                                             {
            //                                                 throw new FormatException();
            //                                             }
            //                                             Header();
            //                                             TitleOption1();
            //                                             Random ElRandom1 = new Random();
            //                                             //for (int j = 0; j < i; j++)
            //                                             {
            //                                                 //RandomTree.InsertMultiWay(ElRandom1.Next(min, max));
            //                                             }
            //                                             Console.WriteLine("Se ha llenado satisfactoriamente el árbol. Presione cualquier tecla para ver los recorridos.");
            //                                             Console.ReadKey();
            //                                             Header();
            //                                             TitleOption1();
            //                                             a = false;
            //                                             TitleTraversal(1);
            //                                             //List<int> Recorrido = RandomTree.Preorder();
            //                                             string result = "";
            //                                             int iterardor = 1;
            //                                             /*foreach (int number in Recorrido)
            //                                             {
            //                                                 result += number.ToString() + ",";
            //                                                 if ((iterardor % m) == 0)
            //                                                 {
            //                                                     result += Environment.NewLine;
            //                                                 }
            //                                                 iterardor++;
            //                                             }*/
            //                                      Console.WriteLine(result);
            //                                    TitleTraversal(2);
            //                                    //Recorrido = RandomTree.Inorder();
            //                                    result = "";
            //                                    iterardor = 1;
            //                                    /*foreach (int number in Recorrido)
            //                                    {
            //                                        result += number.ToString() + ",";
            //                                        if ((iterardor % m) == 0)
            //                                        {
            //                                            result += Environment.NewLine;
            //                                        }
            //                                        iterardor++;
            //                                    }*/
            //                                    Console.WriteLine(result);
            //                                    TitleTraversal(3);
            //                                    //Recorrido = RandomTree.Postorder();
            //                                    result = "";
            //                                    iterardor = 1;
            //                                    /*foreach (int number in Recorrido)
            //                                    {
            //                                        result += number.ToString() + ",";
            //                                        if ((iterardor % m) == 0)
            //                                        {
            //                                            result += Environment.NewLine;
            //                                        }
            //                                        iterardor++;
            //                                    }*/
            //                                    Console.WriteLine(result + "\n");
            //                                    string f = "Finalizaron los recorridos. Presione una tecla para volver al menú principal.";
            //                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (f.Length / 2)) + "}", f) + "\n");
            //                                    Console.ReadKey();
            //                                }
            //                                catch
            //                                {
            //                                    Header();
            //                                    string e = "Ocurrió un error. Presione una tecla para volver al menú principal.";
            //                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (e.Length / 2)) + "}", e) + "\n");
            //                                    Console.ReadKey();
            //                                    a = false;
            //                                }
            //                            }
            //                        }
            //                        break;
            //                    case 2:
            //                        {
            //                            //Laboratorio1_ED2.MultiwayTree<int> Tree = new MultiwayTree<int>();
            //                            bool b = true;
            //                            while (b)
            //                            {
            //                                try
            //                                {
            //                                    Header();
            //                                    TitleOption2();
            //                                    Console.WriteLine("Ingrese el grado del árbol B (debe ser mayor a 2):");
            //                                    int m = Convert.ToInt32(Console.ReadLine());
            //                                    if (m < 2)
            //                                    {
            //                                        throw new FormatException();
            //                                    }
            //                                    //Tree.SetM(m);
            //                                    Header();
            //                                    TitleOption2();
            //                                    Console.WriteLine("Ingrese un número para insertarlo en el árbol: (Si desea parar ingrese otro caracter o presione enter)");
            //                                    //List<int> AddMe = new List<int>();
            //                                    bool stop = false;
            //                                    while (!stop)
            //                                    {
            //                                        try
            //                                        {
            //                                            int me = Convert.ToInt32(Console.ReadLine());
            //                                            //AddMe.Add(me);
            //                                        }
            //                                        catch
            //                                        {
            //                                            stop = true;
            //                                            //if (AddMe.Count == 0)
            //                                            {
            //                                                throw new FormatException();
            //                                            }
            //                                        }
            //                                    }
            //                                    Header();
            //                                    TitleOption2();
            //                                    /*foreach (int n in AddMe)
            //                                    {
            //                                        Tree.InsertMultiWay(n);
            //                                    }*/
            //                                    Console.WriteLine("Se ha llenado satisfactoriamente el árbol. Presione cualquier tecla para ver los recorridos.");
            //                                    Console.ReadKey();
            //                                    Header();
            //                                    TitleOption2();
            //                                    b = false;
            //                                    TitleTraversal(1);
            //                                    //List<int> Recorrido = Tree.Preorder();
            //                                    string result = "";
            //                                    int iterardor = 1;
            //                                    /*foreach (int number in Recorrido)
            //                                    {
            //                                        result += number.ToString() + ",";
            //                                        if ((iterardor % m) == 0)
            //                                        {
            //                                            result += Environment.NewLine;
            //                                        }
            //                                        iterardor++;
            //                                    }*/
            //                                    Console.WriteLine(result);
            //                                    TitleTraversal(2);
            //                                    //Recorrido = Tree.Inorder();
            //                                    result = "";
            //                                    iterardor = 1;
            //                                    /*foreach (int number in Recorrido)
            //                                    {
            //                                        result += number.ToString() + ",";
            //                                        if ((iterardor % m) == 0)
            //                                        {
            //                                            result += Environment.NewLine;
            //                                        }
            //                                        iterardor++;
            //                                    }*/
            //                                    Console.WriteLine(result);
            //                                    TitleTraversal(3);
            //                                    //Recorrido = Tree.Postorder();
            //                                    result = "";
            //                                    iterardor = 1;
            //                                    /*foreach (int number in Recorrido)
            //                                    {
            //                                        result += number.ToString() + ",";
            //                                        if ((iterardor % m) == 0)
            //                                        {
            //                                            result += Environment.NewLine;
            //                                        }
            //                                        iterardor++;
            //                                    }*/
            //                                    Console.WriteLine(result + "\n");
            //                                    string f = "Finalizaron los recorridos. Presione una tecla para volver al menú principal.";
            //                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (f.Length / 2)) + "}", f) + "\n");
            //                                    Console.ReadKey();
            //                                }
            //                                catch
            //                                {
            //                                    Header();
            //                                    string e = "Ocurrió un error. Presione una tecla para volver al menú principal.";
            //                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (e.Length / 2)) + "}", e) + "\n");
            //                                    Console.ReadKey();
            //                                    b = false;
            //                                }
            //                            }
            //                        }
            //                        break;
            //                    case 3:
            //                        {
            //                            exit = true;
            //                        }
            //                        break;
            //                }
            //            }
            //            catch
            //            {
            //                Console.WriteLine("Ha ocurrido un error.");
            //                Console.Clear();
            //            }
            //        }
            //    }
        }
}
