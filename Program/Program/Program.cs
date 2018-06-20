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
            CustomList<int> customList = new CustomList<int>();

            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);

            foreach (int integer in customList)
            {
                Console.WriteLine(integer);
            }
            Console.ReadLine();

            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }
            Console.ReadLine();
            
        }
    }
}
