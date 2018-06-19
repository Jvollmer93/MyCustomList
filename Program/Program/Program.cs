using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(9);
            list.Add(8);
            list.Add(7);
            list.Add(6);
            list.Add(5);
            list.Add(4);
            list.Add(3);
            list.Add(2);
            list.Add(1);
            list.Add(0);//{9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
            Console.WriteLine(list);
            Console.ReadLine();
            string listString = list.ToString();//"98756543210"
            Console.WriteLine(listString);
            Console.ReadLine();
        }
    }
}
