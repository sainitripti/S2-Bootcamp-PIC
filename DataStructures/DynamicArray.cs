using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DynamicArray
    {

        #region Data members
        int[] buffer;
        int length;
        int itemCount;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int ItemCount
        {
            get { return itemCount; }
            set { itemCount = value; }
        }
        #endregion
        #region Constructors
        public DynamicArray()
        {
            buffer = new int[10];
            length = 10;
        }
        public DynamicArray(int capacity)
        {
            buffer = new int[capacity];
            length = capacity;
        }

        #endregion

        #region methods

        public void Set_Item(int index, int value)
        {
            if (index >= this.buffer.Length)
            {
                int[] tempBuffer = new int[index + 10];
                buffer.CopyTo(tempBuffer, 0);
                buffer = tempBuffer;
                length = index + 10;
            }
            buffer[index] = value;
            itemCount++;
        }
        public int Get_Item(int index)
        {
            return this.buffer[index];
        }
        #endregion
    }
}