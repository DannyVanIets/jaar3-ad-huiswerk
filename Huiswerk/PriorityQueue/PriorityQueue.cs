using System;


namespace AD
{
    public partial class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int size;   // Number of elements in heap
        public T[] array;  // The heap array

        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------
        public PriorityQueue()
        {
            array = new T[DEFAULT_CAPACITY];
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            array = new T[DEFAULT_CAPACITY];
            // of is array = null; misschien beter? Moeten we effe bekijken.
            size = 0;
        }

        public void Add(T x)
        {
            size++;
            if (size == 0)
            {
                array[1] = x;
            }
            else
            {
                if (size + 1 == array.Length)
                {
                    // Double the array size here!
                }
                array[size] = x;
            }
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            if (size == 0)
            {
                throw new PriorityQueueEmptyException();
            }
            else
            {
                size--;
                return default;
            }
        }

        public override string ToString()
        {
            if (size == 0)
            {
                return "";
            }
            string everythingInTheArray = "";
            for (int i = 1; i <= size; i++)
            {
                if (i < size)
                {
                    everythingInTheArray += $"{array[i]} ";
                }
                else
                {
                    everythingInTheArray += $"{array[i]}";
                }
            }
            return everythingInTheArray;
        }

        private void PercolateDown(int node)
        {

        }

        private void PercolateUp(int node)
        {

        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            throw new System.NotImplementedException();
        }

        public void BuildHeap()
        {
            throw new System.NotImplementedException();
        }

    }
}
