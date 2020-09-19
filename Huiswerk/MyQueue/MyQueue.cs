using System.Collections.Generic;

namespace AD
{
    public partial class MyQueue<T> : IMyQueue<T>
    {
        private List<T> queue = new List<T>();

        public bool IsEmpty()
        {
            if (queue.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void Enqueue(T data)
        {
            queue.Add(data);
        }

        public T GetFront()
        {
            if(queue.Count == 0)
            {
                throw new MyQueueEmptyException();
            }
            return queue[0];
        }

        public T Dequeue()
        {
            if(queue.Count == 0)
            {
                throw new MyQueueEmptyException();
            }
            var firstQueueElement = queue[0];
            queue.RemoveAt(0);
            return firstQueueElement;
        }

        public void Clear()
        {
            queue.Clear();
        }
    }
}