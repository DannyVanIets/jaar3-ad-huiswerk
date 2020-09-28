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
                DoubleArrayLength();
                // Check if the new value being added is smaller than the parent.
                // If so, then we will swap the parent with the newly added value.
                // Which is called PercolateUp!
                if (x.CompareTo(array[size / 2]) < 0)
                {
                    PercolateUp(x);
                }
                else
                {
                    array[size] = x;
                }
            }
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            if (size == 0)
            {
                throw new PriorityQueueEmptyException();
            }
            else if (size == 1)
            {
                array = new T[DEFAULT_CAPACITY];
                return default;
            }
            else
            {
                array[1] = array[size];
                array[size] = default;
                size--;
                PercolateDown(1);
                return array[1];
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

        public void DoubleArrayLength()
        {
            if (size + 1 >= array.Length)
            {
                T[] temporaryArray = array;
                array = new T[size * 2];

                for (int i = 0; i < size; i++)
                {
                    array[i] = temporaryArray[i];
                }
            }
        }

        private void PercolateUp(T x)
        {
            // In tempValue we will store the parent temporary.
            T tempValue;

            // In parentPlace we will store the placement of the current parent of the newly added node.
            // In parentPlace will be updated at the end of the while loop,
            // after the newly added node has been swapped with the older parent.
            int parentPlace = size / 2;

            // In swapWithNewNodePlacement we will store the placement of the newly added
            // node and we will update it after it has been swapped.
            int swapWithNewNodePlacement = size;

            while (x.CompareTo(array[parentPlace]) < 0)
            {
                tempValue = array[parentPlace];
                array[parentPlace] = x;
                array[swapWithNewNodePlacement] = tempValue;

                swapWithNewNodePlacement = parentPlace;
                parentPlace /= 2;
            }
        }

        private void PercolateDown(int node)
        {
            T tempValue = array[node];
            int leftChild = node * 2;
            int rightChild = node * 2 + 1;

            if (leftChild < size || rightChild < size)
            {
                if (array[leftChild].CompareTo(array[rightChild]) < 0)
                {
                    array[node] = array[leftChild];
                    array[leftChild] = tempValue;

                    PercolateDown(leftChild);
                }
                else
                {
                    array[node] = array[rightChild];
                    array[rightChild] = tempValue;

                    PercolateDown(rightChild);
                }
            }
            else if (size == 2)
            {
                array[node] = array[leftChild];
                array[leftChild] = tempValue;
            }
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
