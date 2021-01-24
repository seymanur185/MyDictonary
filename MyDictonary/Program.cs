using System;
using System.Collections.Generic;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int, string> Dersler = new Dictionary<int, string>();
            Dersler.Add(1,"Fizik");
            Dersler.Add(2,"Kimya");
            //Console.WriteLine(Dersler[1]);
            //Console.WriteLine(Dersler[2]);
            Console.WriteLine(Dersler.Count);

        }
    }

    class Dictonary<T>
    {
        T[] Id;
        
        T[] tempId;//gecici array 
        
        public Dictonary()
        {
            Id = new T[0];
        }
        public void Add(T item)
        {
            tempId = Id;
            Id = new T[Id.Length+1];
               

            for (int i = 0; i < tempId.Length; i++)
            {
                Id[i] = tempId[i];
            }
            Id[Id.Length - 1] = item;
        }

       
        public int Count
        {
            get { return Id.Length; }

        }

    }
}
