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
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
            string listString = list.ToString();//"98756543210"
            Console.WriteLine(listString);

            Console.ReadLine();//Add and ToString methods work.

            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(4);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);
            list1.Add(8);
            list1.Remove(2);
            list1.Remove(4);
            list1.Remove(6);
            list1.Remove(8);

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
            Console.ReadLine();
            string listString1; 
            listString1 = list1.ToString();
            Console.WriteLine(listString1);
            Console.ReadLine();

            list.Zip(list1);//9,1,8,3,7,5,6,7..
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();


        }
    }
}
