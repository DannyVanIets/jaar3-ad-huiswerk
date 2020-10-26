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

        // Removes the last added element, which will be at the front.
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

        // Every element is added at the beginning, so at 0.
        public void Push(T data)
        {
            stack.AddFirst(data);
        }

        // Gets the element at the top, the beginning of the stack.
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