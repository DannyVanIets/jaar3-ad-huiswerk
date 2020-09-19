using System.Drawing;

namespace AD
{
    public partial class MyStack<T> : IMyStack<T>
    {
        private MyLinkedList<T> stack = new MyLinkedList<T>();

        public bool IsEmpty()
        {
            if (stack.Size() == 0)
            {
                return true;
            }
            return false;
        }

        public T Pop()
        {
            if (stack.Size() == 0)
            {
                throw new MyStackEmptyException();
            }

            T pop = default;

            if (stack.Size() > 0)
            {
                pop = stack.GetFirst();
                stack.RemoveFirst();
            }

            return pop;
        }

        public void Push(T data)
        {
            stack.AddFirst(data);
        }

        public T Top()
        {
            if (stack.Size() == 0)
            {
                throw new MyStackEmptyException();
            }
            return stack.GetFirst();
        }
    }
}