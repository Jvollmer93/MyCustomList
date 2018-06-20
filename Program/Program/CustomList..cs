using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program 
{
    public class CustomList<T> : IEnumerable
    {
        int[] customListArray = new int[10];
        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        public T[] MyArray{ get; set; }
        public T this[int i]
        {
            get { return MyArray[i]; }
            set { MyArray[i] = value; }
        }
        public CustomList()
        {
            count = 0;
            MyArray = new T[Count];
        }
        public IEnumerator GetEnumerator()
        {
            for ( int i = 0; i < customListArray.Length; i++ )
            {
                yield return customListArray[i];
            }
        }
        public void Add(T value)
        {
            count++;
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
            T[] newArray = MyArray;

            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i].Equals(value))
                {
                    count--;
                }
            }

            MyArray = new T[Count];
            int j = 0;

            for (int i = 0; i < Count; i++)
            {
                if (!(newArray[j].Equals(value)))
                {
                    MyArray[i] = newArray[j];
                }
                else
                {
                    do
                    {
                        j++;
                    } while ((newArray[j].Equals(value)));
                    MyArray[i] = newArray[j];
                }
                j++;
            }    
        }
        public override string ToString()
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
            int zipListCounter = zipList.Count;
            int myArrayCounter = Count;
            count += zipListCounter;
            T[] newArray = new T[Count];
            int counter = 0;

            for (int i = 0; i < Count; i++)
            {
                if(zipListCounter > 0)
                {
                    newArray[i + counter + 1] = zipList[i];
                    zipListCounter--;
                }
                else
                {
                    zipListCounter--;
                    if (zipListCounter < -1)
                    {
                        counter--;
                    }
                }
                if(myArrayCounter > 0)
                {
                    newArray[i + counter] = MyArray[i];
                    myArrayCounter--;
                }
                counter++;
            }
            count = newArray.Length;
            MyArray = newArray;
        }
        public void Sort()
        {
            T[] newArray = MyArray;
            for(int i = 0; i < Count; i ++)
            {


            }
        }
        public static CustomList<T> operator + (CustomList<T> x, T y)
        {
            x.Add(y);
            return x;
        }
        public static CustomList<T> operator - (CustomList<T> x, T y)
        {
            x.Remove(y);
            return x;
        }
    }
}
