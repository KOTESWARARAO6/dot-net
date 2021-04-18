using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class genrics
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("1.koti");
            myList.Add("2.anil");
            myList.Add("3.chithnya");
            myList.Add("4.kalyan");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            myList.Sort();
            Console.WriteLine("\n After sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            myList.Remove("kalyan");
            Console.WriteLine("\n Removing of Keerthi");
            foreach (string s in myList)
                Console.WriteLine(s.ToString() + " ");
            myList.Insert(2, "nani");
            Console.WriteLine("\n Inserting of Thulasi at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
        }
    }
}
