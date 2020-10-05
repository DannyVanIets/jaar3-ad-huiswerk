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
            size = 0;
        }

        public int CountOccurences(int n)
        {
            int occurences = 0;
            for (int i = 0; i < size; i++)
            {
                if (data[i] == n)
                {
                    occurences++;
                }
            }
            return occurences;
        }

        public override string ToString()
        {
            if (size == 0)
            {
                return "NIL";
            }

            string everythingInTheList = "[";

            for (int i = 0; i < size; i++)
            {
                everythingInTheList += data[i];

                if (i != size - 1)
                {
                    everythingInTheList += ",";
                }
            }
            everythingInTheList += "]";

            return everythingInTheList;
        }
    }
}
