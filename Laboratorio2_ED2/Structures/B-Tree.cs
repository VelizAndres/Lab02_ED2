using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laboratorio2_ED2
{
    class TreeB<T> where T : IComparable
    {
        private int m = 2;
        //Insertar

        //Eliminar

        //Guardar en disco?

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
