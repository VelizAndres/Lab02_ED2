using System;

namespace Laboratorio2_ED2
{
    class Node<T> where T:IComparable
    {
        //Valores Auxiliares
        public static int m;
        public int[] tamData;
        public int TamVal;
        //    public int capacityLeft;
    
        //Valores  Principales
        public int id;
        public T[] Valores;
        public int ParentNode;
        public int[] Children;
        public int usedSpace = 0;
        public int CantHijos;


        public Node() 
        {
          
           
        }
       public Node(T value, int grado, int SizeVal, int identi)
        {
            id = identi;
            m = grado;
            Children = new int[m];
            Valores = new T[m - 1];
            usedSpace++;
            Valores[0] = value;
            TamVal = SizeVal;
            tamData = new int[4] { 11, 11, 11*m, (SizeVal+1)*(m-1)};
        }

        public void InsertInNode(T value)
        {
            //            Valores[m - capacityLeft - 1] = value;
            Valores[usedSpace] = value;
          //  capacityLeft--;
          //  usedSpace++;
            SortValuesWithinNode();
        }

        private void SortValuesWithinNode()
        {
            for (int i = 0; i < usedSpace - 1; i++)
            {
                for (int j = 0; j < usedSpace - i ; j++)
                {
                    if (Valores[j].CompareTo(Valores[j + 1]) == 1)
                    {
                        //swap de valores dentro del nodo
                        T temp = Valores[j];
                        Valores[j] = Valores[j + 1];
                        Valores[j + 1] = temp;
                    }
                }
            }
        }




        public string SendText()
        {
            string campos = string.Format("{0,11}", id) + "|" + string.Format("{0,11}", ParentNode) + "|"; 
            string texthijos = "";
            for(int i=0; i< Children.Length;i++)
            {
                texthijos += string.Format("{0,10}", Children[i])+"/";
            }
            texthijos += "|";
           string textvalores = "";
           for (int i = 0; i < Valores.Length; i++)
            {
                textvalores += string.Format("{0," +TamVal+ "}", Valores[i].ToString())+"/";
            }
            textvalores += Environment.NewLine;
            campos += texthijos + textvalores;
            return campos;
        }


        public void GetValues(string data, int grado, int SizeVal, Delegate Convert, Delegate Vacio)
        {
            TamVal = SizeVal;
            m = grado;
            tamData = new int[4] { 11, 11, 11 * m, (SizeVal + 1) * (m - 1) };
            string[] contenedor = data.Split("|");
            string[] aux = new string[4];
            int pos = 0;
            bool fail = true;
            for (int i = 0; i < aux.Length; i++)
            {
                fail = true;
                aux[i] = contenedor[pos];
                while (aux[i].Length != tamData[i])
                {
                    pos++;
                    aux[i] += "|" + contenedor[pos];
                    fail = false;
                }
                if (fail) { pos++;}
            }
            id = int.Parse(aux[0]);
            ParentNode = int.Parse(aux[1]);
            Children = new int[m];
            Valores = new T[m - 1];
            //Add Hijos
            string[] hijos = aux[2].Split("/");
            for(int j=0;j<m;j++)
            {
                if (int.Parse(hijos[j]) != 0 ) { CantHijos++; };
                Children[j] = int.Parse(hijos[j]);
            }
            //Add Values
            string[] aux_val = aux[3].Split("/");
            int CapacityLef = m-1;
            for (int k = 0; k < m-1; k++)
            {
                Valores[k] = (T)Convert.DynamicInvoke(aux_val[k].Trim());
                if (Valores[k].CompareTo((T)Vacio.DynamicInvoke())==0) { CapacityLef--; }
            }
            usedSpace = CapacityLef;
        }
     

    }
}
