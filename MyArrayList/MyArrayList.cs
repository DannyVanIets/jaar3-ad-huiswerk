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
            size = capacity; //Dit moet nog aangepast worden.
            if (size > capacity)
            {
                throw new System.NotImplementedException();
            }

            if (data.Length == 0)
            {
                return null;
            }
            else
            {
                return "alle cijfers";
            }
        }

        public void Add(int n)
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }

        public int Get(int index)
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }

        public void Set(int index, int n)
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }

        public int Capacity()
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }

        public int Size()
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }

        public int CountOccurences(int n)
        {
            // Write implementation here
            throw new System.NotImplementedException();
        }
    }
}
