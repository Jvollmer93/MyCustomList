using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class CustomList<T>
    {
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public void Add(T value)
        {
            //insert value at index 0
        }
        public void Remove(T value)
        {
            //loop through every index of list, if index == value. Remove
            //for(int i = 0; i < Count; i ++)
            //{
            //    if( value == CustomList[i] )
            //    {
            //        CustomList = CustomList - CustomList[i];
            //    }
            //}
        }
        public void ToString(T value)
        {

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
        public void GetCount()
        {

        }
        public void Zip(T value1)
        {

        }

    }
}
