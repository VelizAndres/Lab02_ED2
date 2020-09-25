using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Laboratorio2_ED2
{
    public class TreeB<T> where T : IComparable
    {
        public Delegate Conversor;

        private int grado;
        private int root;
        private int next;
        private int[] data;
        private string DirectoryData;
        private int SizeValores;
        public int SizeNode;

        //Create a File and Add Metadata
        public void CreateData(int order, int TamValores, Delegate Convert)
        {
            //string DirectoryOfNode = Directory.GetCurrentDirectory() + "\\Data\\" + "Btree" + ".txt";
            grado = order;
            SizeValores = TamValores;
            root = 0;
            next = 1;
            Conversor = Convert;
            SizeNode = 25+ (11 * grado) + ((SizeValores + 1) * (grado - 1));

            DirectoryData = Directory.GetCurrentDirectory() + "\\Btree" + ".txt";
            StreamWriter Creator = new StreamWriter(DirectoryData);
            string metada = "Raiz:" + $"{root:000000;-00000}" + Environment.NewLine + "Proxima Posicion:" + $"{next:000000;-00000}" + Environment.NewLine;
            string campos =  string.Format("{0,11}", "ID") + "|" + string.Format("{0,11}", "PADRE") + "|" + string.Format("{0," + 11 * grado + "}", "HIJOS") + "|" + string.Format("{0," + TamValores * (grado - 1) + "}", "VALORES") + Environment.NewLine;
            metada += campos;
            int tamcamp= 42 + 27 + 11 * grado + 11 * (grado - 1);
            data = new int[4] { 5, 30,42 ,tamcamp };
            Creator.WriteLine(metada);
            Creator.Close();
        }
        //Insertar
        public void InsertTreeB(T value)
        {
            if (root == 0)
            {
                root++;
                next++;
                WriteNodeInDrive(new Node<T>(value,grado,SizeValores,root), root);
                MoodRoot();
            }
            else
            {
                Node<T> temp = new Node<T>();
                temp.GetValues(GetTextNode(root),grado,SizeValores, Conversor);
            }
        }


        private void RecorrerTreeB(Node<T> padre, T Valor,Delegate Conversor)
        {
            Node<T> Aux = new Node<T>();
            Aux.GetValues(GetTextNode(padre.id), grado, SizeValores, Conversor);
            if (Aux.CantHijos ==0 )
            {
                if(Aux.usedSpace<(grado - 1))
                {
                    Aux.InsertInNode(Valor);
                    WriteNodeInDrive(Aux, Aux.id);
                }
                else
                {
                    int posMitad = ((grado + 1) / 2) - 1;
                    int[] PosNod = new int[2] { Aux.id, next};
                    int[] Resguard_Hijos = new int[(grado / 2)];
                    T[] Resguard_Valores= new T[(grado / 2)- 1];
                    Node<T> CreateNode = new Node<T>() { id = next, ParentNode = Aux.ParentNode };
                    //Aqui va cuando supera la cantidad maxima
                    T[] ValoresMax = new T[grado];
                    for(int i=0;i<grado;i++)
                    {
                        ValoresMax[i] = Aux.Valores[i];
                    }
                    ValoresMax[grado - 1] = Valor;
                    for (int i = 0; i < grado- 1; i++)
                    {
                        for (int j = 0; j < grado - i - 1; j++)
                        {
                            if (ValoresMax[j].CompareTo(ValoresMax[j + 1]) == 1)
                            {
                                //swap de valores dentro del nodo
                                T temp = ValoresMax[j];
                                ValoresMax[j] = ValoresMax[j + 1];
                                ValoresMax[j + 1] = temp;
                            }
                        }
                    }
                    //Save Values
                    int iterador = 0;
                    for(int j=0;j<grado-1;j++)
                    {
                        if (j < posMitad) { Aux.Valores[j] = ValoresMax[j]; }
                        else { Aux.Valores[j] = default; }
                        if (j>posMitad)
                        {
                            Resguard_Valores[iterador] = ValoresMax[j];
                            iterador++;
                        }
                    }
                    //Save Children
                    iterador = 0;
                    for (int j = 0; j < grado; j++)
                    {
                        if (j > posMitad) 
                        {
                            Resguard_Hijos[iterador] = Aux.Children[j];
                            iterador++;
                            Aux.Children[j] = 0;
                        }
                    }
                    T MEDIO= ValoresMax[i]
                }
            }

            else 
                {
                for (int i = 0; i < Aux.usedSpace; i++)
                {
             //       if ()
                }
            }
       
        
        }


        public Node<T> 




        void WriteNodeInDrive(Node<T> nodeMater, int id)
        {
            using (FileStream file = new FileStream(DirectoryData, FileMode.Open))
            {
                using (StreamWriter Writer = new StreamWriter(file))
                {
                    file.Seek(data[3]+(id-1)*SizeNode, SeekOrigin.Begin);
                    Writer.WriteLine(nodeMater.SendText());
                    Writer.Close();
                }
            }
        }

        public string GetTextNode(int id)
        {
            string DataNode = "";
            using (FileStream file = new FileStream(DirectoryData, FileMode.Open))
            {
                using (StreamReader lector = new StreamReader(file))
                {
                    file.Seek(data[3] + (id-1) * SizeNode, SeekOrigin.Begin);
                    DataNode=lector.ReadLine();
                    lector.Close();
                }
            }
            return DataNode;
        }


        //Eliminar




        public void MoodRoot()
        {
            using (FileStream file = new FileStream(DirectoryData,FileMode.Open))
            {
                    using (StreamWriter escritor = new StreamWriter(file))
                    {
                        file.Seek(data[0], SeekOrigin.Begin);

                    escritor.WriteLine($"{root:000000;-00000}");
                    }
                file.Close();
            }
        }
    











        /// <summary>
        /// Este método solo crea un archivo txt en blanco a partir de un nombre para el archivo
        /// </summary>
        void CreateNodeInDrive(string id)
        {
            string DirectoryOfNode = Directory.GetCurrentDirectory() + "\\Data\\" + id + ".txt";
            StreamWriter Creator = new StreamWriter(DirectoryOfNode);
            Creator.WriteLine("");
            Creator.Close();
        }

        void WriteNodeInDrive (string something, string id)
        {
            string [] s = new string[3];
            string DirectoryOfData = Directory.GetCurrentDirectory() + "\\Data\\" + id + ".txt";
            StreamWriter Writer = new StreamWriter(DirectoryOfData);
            Writer.Write(something);
            Writer.Close();
        }

        T [] GetValuesOfNode (string id)
        {
            T[] response = new T[grado - 1];
            string DataDirectory = Directory.GetCurrentDirectory() + "\\Data\\" + id + ".txt";
            StreamReader Reader = new StreamReader(DataDirectory);
            string rawData = Reader.ReadToEnd();
            //Aquí habría que convertir de alguna forma la rawData a un arreglo de valores T
            return response;
        }

        string [] GetMetadataOfNode(string id)
        {
            string [] response = new string [5];
            string DataDirectory = Directory.GetCurrentDirectory() + "\\Data\\" + id + ".txt";
            StreamReader Reader = new StreamReader(DataDirectory);
            string rawData = Reader.ReadToEnd();
            //Aquí habría que convertir de alguna forma la rawData a un arreglo de strings que tenga la metadata.
            return response;
        }

    }
}
