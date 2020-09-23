using System;

namespace Laboratorio2_ED2
{
    class Node<T> where T:IComparable
    {
        public static int m;
        public T Value { get; set; }
        public T[] Valores;
        public int capacityLeft;
        public Node<T> ParentNode;
        public Node<T>[] Children;
        public int usedSpace = 0;


        public Node(T value, int MNode)
        {
            m = MNode;
            Children = new Node<T>[m];
            Valores = new T[m - 1];
            capacityLeft = m - 1;
            capacityLeft--;
            usedSpace++;
            Valores[0] = value;
        }



    }
}
