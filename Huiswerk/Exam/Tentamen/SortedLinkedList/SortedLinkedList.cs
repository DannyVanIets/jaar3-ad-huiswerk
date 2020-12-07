using System;
using System.Collections.Generic;
using System.Text;

namespace AD
{
    public partial class SortedLinkedList : ISortedLinkedList
    {
        public SortedLinkedListNode first;
        public SortedLinkedListNode firstSorted;

        public SortedLinkedList()
        {
            first = firstSorted = null;
        }

        public SortedLinkedListNode GetFirst()
        {
            return first;
        }
        public SortedLinkedListNode GetFirstSorted()
        {
            return firstSorted;
        }
        public void AddFirst(int value)
        {
            if (first != null)
            {
                SortedLinkedListNode old = first;
                SortedLinkedListNode newNode = new SortedLinkedListNode(value);
                first = newNode;
                first.next = old;

                if (first.data < firstSorted.data)
                {
                    firstSorted = first;
                    firstSorted.nextSorted = old;
                }
                else
                {
                    firstSorted = old;
                    firstSorted.nextSorted = first;
                }
            }
            else
            {
                first = new SortedLinkedListNode(value);
                firstSorted = first;
            }
        }

        public SortedLinkedListNode Find(int data)
        {
            SortedLinkedListNode currentNode = first;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return currentNode;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }
            return null;
        }

        public override string ToString()
        {
            if (first != null)
            {
                string everyNode = "";
                SortedLinkedListNode currentNode = first;
                while (currentNode != null)
                {
                    everyNode += currentNode.data.ToString();
                    if (currentNode.next != null)
                    {
                        everyNode += " -> ";
                    }
                    currentNode = currentNode.next;
                }
                return everyNode;
            }
            return "NULL";
        }

        public string ToStringSorted()
        {
            if (first != null)
            {
                string everyNode = "[ ";
                SortedLinkedListNode currentNode = firstSorted;
                while (currentNode != null)
                {
                    everyNode += currentNode.data.ToString();
                    if (currentNode.nextSorted != null)
                    {
                        everyNode += ", ";
                    }
                    else
                    {
                        everyNode += " ]";
                    }
                    currentNode = currentNode.nextSorted;
                }
                return everyNode;
            }
            return "[]";
        }
    }
}
