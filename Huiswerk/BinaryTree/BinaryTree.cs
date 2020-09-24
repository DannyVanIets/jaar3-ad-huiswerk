namespace AD
{
    public partial class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Cunstructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>(rootItem, null, null);
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            int size = 0;
            if (root != null)
            {
                return SizeWithNode(root, size);
            }
            return size;
        }

        public int SizeWithNode(BinaryNode<T> node, int size)
        {
            size++;
            if (node.left != null)
            {
                SizeWithNode(node.left, size);
            }
            else if (node.right != null)
            {
                SizeWithNode(node.right, size);
            }
            return size;
        }

        public int Height()
        {
            int height = -1;
            if (root != null)
            {
                return CalculateHeight(root, height, height);
            }
            return height;
        }

        public int CalculateHeight(BinaryNode<T> node, int height, int max)
        {
            height++;
            if(height > max)
            {
                max = height;
            }
            if (node.left != null)
            {
                CalculateHeight(node.left, height, max);
            }
            else if (node.right != null)
            {
                CalculateHeight(node.right, height, max);
            }
            return max;
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            if (root != null)
            {
                return false;
            }
            return true;
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            throw new System.NotImplementedException();
        }

        public string ToPrefixString()
        {
            if (root == null)
            {
                return "NIL";
            }
            return "";
        }

        public string ToInfixString()
        {
            if (root == null)
            {
                return "NIL";
            }
            return "";
        }

        public string ToPostfixString()
        {
            if (root == null)
            {
                return "NIL";
            }
            return "";
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithOneChild()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithTwoChildren()
        {
            throw new System.NotImplementedException();
        }
    }
}