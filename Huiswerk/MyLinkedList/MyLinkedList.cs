namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyLinkedListNode<T> head;
        private int size;

        public MyLinkedList()
        {
            head = new MyLinkedListNode<T>(); //Deze bespreken tijdens de les op locatie.
            // gaat over de test MyLinkedList_7_Internal_1_Constructor().
        }

        public void AddFirst(T data)
        {
            if (size > 0)
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

        public override string ToString()
        {
            if(size == 0)
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