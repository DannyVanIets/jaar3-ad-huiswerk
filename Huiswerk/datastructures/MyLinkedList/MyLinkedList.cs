namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        // Head is what you will use for everything.
        // It's what you start with and then go through the rest of all the nodes.
        public MyLinkedListNode<T> head;
        private int size;

        public MyLinkedList()
        {
            head = null;
        }

        // Through this function we will place the new node at the head and the old one after that.
        // head.next = old head, head.data = data.
        public void AddFirst(T data)
        {
            if (size == 0)
            {
                head = new MyLinkedListNode<T>();
            }
            else if (size > 0)
            {
                MyLinkedListNode<T> old = new MyLinkedListNode<T>
                {
                    data = head.data,
                    next = head.next
                };
                head.next = old;
            }
            head.data = data;
            size++;
        }

        public T GetFirst()
        {
            if (size == 0)
            {
                throw new MyLinkedListEmptyException();
            }
            return head.data;
        }

        // Replace the head with everything from head.next if the size is bigger than 1.
        public void RemoveFirst()
        {
            if (size == 0)
            {
                throw new MyLinkedListEmptyException();
            }
            else if (size == 1)
            {
                head.data = default;
                size--;
            }
            else
            {
                head.data = head.next.data;
                head.next = head.next.next;
                size--;
            }
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        // We will go through head.next until we are at the place where we want to be.
        // There we will add a new node (and potentionally replace an old one).
        public void Insert(int index, T data)
        {
            if (index < 0 || index > size)
            {
                throw new MyLinkedListIndexOutOfRangeException();
            }
            else if (index == 0)
            {
                AddFirst(data);
            }
            else
            {
                MyLinkedListNode<T> previousNode = new MyLinkedListNode<T>();
                MyLinkedListNode<T> nextNode = head;

                for (int i = 0; i < index; i++)
                {
                    previousNode = nextNode;
                    nextNode = nextNode.next;
                }

                MyLinkedListNode<T> newNode = new MyLinkedListNode<T>
                {
                    data = data,
                    next = nextNode
                };

                previousNode.next = newNode;
                size++;
            }
        }

        // If List is bigger than 0, will display it like this for example: "[1,2,3]"
        public override string ToString()
        {
            if (size == 0)
            {
                return "NIL";
            }

            string everythingInTheList = "[";
            MyLinkedListNode<T> currentNode = head;

            for (int i = 0; i < size; i++)
            {
                everythingInTheList += currentNode.data;
                currentNode = currentNode.next;

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