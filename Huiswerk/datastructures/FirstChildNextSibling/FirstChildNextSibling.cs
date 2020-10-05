using System;

namespace AD
{
    public partial class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FCNSNode<T> root;
        public int size;
        public string tree;

        public int Size()
        {
            if (root != null)
            {
                SizeWithNode(root);
            }
            return size;
        }

        public void SizeWithNode(FCNSNode<T> node)
        {
            size++;
            if (node.firstChild != null)
            {
                SizeWithNode(node.firstChild);
            }
            if (node.nextSibling != null)
            {
                SizeWithNode(node.nextSibling);
            }
        }

        public void PrintPreOrder()
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                string spaces = "   ";
                if (root.firstChild != null)
                {
                    PreOrder(root.firstChild, spaces);
                }
                if (root.nextSibling != null)
                {
                    PreOrder(root.nextSibling, spaces);
                }
            }
        }

        public void PreOrder(FCNSNode<T> node, string spaces)
        {
            Console.WriteLine(spaces + node.data);
            if (node.firstChild != null)
            {
                string moreSpaces = spaces + "   ";
                PreOrder(node.firstChild, moreSpaces);
            }
            if (node.nextSibling != null)
            {
                PreOrder(node.nextSibling, spaces);
            }
        }

        public override string ToString()
        {
            if (root == null)
            {
                return "NIL";
            }
            else
            {
                AddToString(root);
                return tree;
            }
        }

        public void AddToString(FCNSNode<T> node)
        {
            tree += node.data.ToString();
            if (node.firstChild != null)
            {
                tree += ",FC(";
                AddToString(node.firstChild);
            }
            if (node.nextSibling != null)
            {
                tree += ",NS(";
                AddToString(node.nextSibling);
            }
            if (root != node)
            {
                tree += ")";
            }
        }
    }
}