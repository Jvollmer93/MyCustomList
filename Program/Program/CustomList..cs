using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class CustomList<T> : IEnumerable<T>
    {
        public int Count { get; set; }
        public int Capatcity { get; set; }
        public T[] MyArray { get; set; }
        public T this[int i]
        {
            get { return MyArray[i]; }
            set { MyArray[i] = value; }
        }
        public void Add(T value)
        {
            Count++;
            T[] newArray = MyArray;
            MyArray = new T[Count];

            for ( int i = 0; i < newArray.Length; i++)
            {
                MyArray[i] = newArray[i];   
            }

            MyArray[Count - 1] = value;              
        }
        public void Remove(T value)
        {
            MyArray = new T[Count];

            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] != value)
                {
                    MyArray[i] = newArray[i];
                }
                else if (MyArray[i] == value)
                {
                    Count--;
                }
            }
        }
        public string ToString()
        {
            string arrayString = "";

            for (int i = 0; i < MyArray.Length; i++)
            {
                arrayString += MyArray[i];
            }

            return arrayString;
        }
        public void Zip(CustomList<T> zipList)
        {
            T[] newArray = new Array[MyArray.Length + zipList.Length];
            int counter = 0;

            for (int i = 0; i < MyArray.length; i++)
            {
                newArray.Insert(i + counter, zipList[i]);
                newArray.Insert(i + counter, MyArray[i]);
                counter++;
            }

            Count = counter * 2;
            MyArray = newArray;
        }

        //public static CustomList<T> operator +(T x, T y)
        //{
        //    T result = x + y;
        //    return result;
        //}
        //public static CustomList<T> operator -(T x, T y)
        //{
        //    T result = x - y;
        //    return result;
        //}

    }
}
