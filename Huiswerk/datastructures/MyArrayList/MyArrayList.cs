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

        // It's an array, so it's not difficult to understand what's going on here.
        // First element will be on arrayplace = 0, the next one on 1, etc.
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

        // Set? More like update.
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

        // If size is bigger than 0, it will display for example: [1,2,3]
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
