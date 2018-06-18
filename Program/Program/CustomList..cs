using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class CustomList<T>
    {
        public int Count; { get; set; }
        public int Capatcity; { get; set; }
        public T[] myArray; { get; set; }

        public Add(T value)
        {
            Count++;
            T[] newArray = myArray;
            myArray = new T[Count];

            for ( int i = 0; i < newArray.Length; i++)
            {
                myArray[i] = newArray[i];   
            }

            myArray[Count - 1] = value;

            return myArray;              
        }
        public Remove(T value)
        {
            T[] newArray = myArray;
            myArray = new T[Count];

            for ( int i = 0; i < newArray.Length; i++ )
            { 
                if( newArray[i] != value )
                {
                    myArray[i] = newArray[i];
                }
                else if ( newArray[i] == value )
                {
                    Count--;
                }
            }

            return myArray;
        }
        public string ToString()
        {
            string arrayString = "";
               
            for( int i = 0; i < myArray.Length; i++ )
            {
                arrayString += myArray[i];
            }

            return arrayString;
        }
        public Zip(T zipArray)
        {
            newArray T[] = new Array[myArray.length + zipArray.length];
            int counter = 0;

            for (int i = 0; i < myArray.length; i++)
            {
            newArray.Insert(i + counter, zipArray[i]);
            newArray.Insert(i + counter, myArray[i]);
            counter++;
            }

            Count = counter * 2;
            myArray = newArray;

            return myArray;
        }

        public static CustomList<T> operator + (CustomList<T> x, CustomList<T> y)
        {
            CustomList<T> result = x + y;
            return result;
        }
        public static CustomList<T> operator - (CustomList<T> x, CustomList<T> y)
        {
            CustomList<T> result = x - y;
            return result;
        }

    }
}
