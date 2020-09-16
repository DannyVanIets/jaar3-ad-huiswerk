using System.Collections.Generic;

namespace AD
{
    public partial class MyArrayList : IMyArrayList
    {
        private int[] data;
        private int size;

        public MyArrayList(int capacity)
        {
            data = new int[capacity];
        }

        public void Add(int n)
        {
            if (size >= data.Length)
            {
                throw new MyArrayListFullException();
            }
            else
            {
                data[size] = n;
                size++;
            }
        }

        public int Get(int index)
        {
            if (index < 0 || index > size - 1)
            {
                throw new MyArrayListIndexOutOfRangeException();
            }
            return data[index];
        }

        public void Set(int index, int n)
        {
            if (index < 0 || index > size - 1)
            {
                throw new MyArrayListIndexOutOfRangeException();
            }
            else
            {
                data[index] = n;
            }
        }

        public int Capacity()
        {
            return data.Length;
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            data = new int[data.Length];
        }

        public int CountOccurences(int n)
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }
    }
}
