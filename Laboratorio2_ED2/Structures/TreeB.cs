using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Laboratorio2_ED2
{
    public class TreeB<T> where T : IComparable
    {
        public Delegate Conversor;

        private int m;
        private int root;
        private int next;
        private int[] data;
        private string DirectoryData;
        private int SizeValores;
        public int SizeNode;

        /*    public void SetM(int val,int ValoresTam)
            {
                m = val;
                SizeValores = ValoresTam;
             }*/

        //Create a File and Add Metadata
        public void CreateData(int grado, int TamValores, Delegate Convert)
        {
            //string DirectoryOfNode = Directory.GetCurrentDirectory() + "\\Data\\" + "Btree" + ".txt";
            m = grado;
            SizeValores = TamValores;
            root = 0;
            next = 1;
            Conversor = Convert;
            SizeNode = 25+ (11 * m) + ((SizeValores + 1) * (m - 1));

            DirectoryData = Directory.GetCurrentDirectory() + "\\Btree" + ".txt";
            StreamWriter Creator = new StreamWriter(DirectoryData);
            string metada = "Raiz:" + $"{root:000000;-00000}" + Environment.NewLine + "Proxima Posicion:" + $"{next:000000;-00000}" + Environment.NewLine;
            string campos =  string.Format("{0,11}", "ID") + "|" + string.Format("{0,11}", "PADRE") + "|" + string.Format("{0," + 11 * m + "}", "HIJOS") + "|" + string.Format("{0," + TamValores * (m - 1) + "}", "VALORES") + Environment.NewLine;
            metada += campos;
            int tamcamp= 42 + 27 + 11 * m + 11 * (m - 1);
            //  data = new int[4] { 5, 30,42 ,tamcamp };
            data = new int[4] { 5, 30,42 ,tamcamp };
            Creator.WriteLine(metada);
            Creator.Close();
        }
        //Insertar
        public void InsertTreeB(T value)
        {
            if (root == 0)
            {
                WriteNodeInDrive(new Node<T>(value,m,SizeValores), 1);
                root++;
                next++;
            }
            else
            {
                Node<T> nodito = new Node<T>();
                nodito = nodito.GetText(CreateTextNode("5"), Conversor);
            }
        }
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

        public string CreateTextNode(string id)
        {
            string DataNode = "";
            using (FileStream file = new FileStream(DirectoryData, FileMode.Open))
            {
                using (StreamReader lector = new StreamReader(file))
                {
                    file.Seek(data[3] + (int.Parse(id)-1) * SizeNode, SeekOrigin.Begin);
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
            T[] response = new T[m - 1];
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
