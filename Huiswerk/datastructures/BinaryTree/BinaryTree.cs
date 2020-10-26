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
                size = SizeWithNode(node.left, size);
            }
            if (node.right != null)
            {
                size = SizeWithNode(node.right, size);
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
            if (height > max)
            {
                max = height;
            }
            if (node.left != null)
            {
                max = CalculateHeight(node.left, height, max);
            }
            if (node.right != null)
            {
                max = CalculateHeight(node.right, height, max);
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
            if (t1 == null)
            {
                root = new BinaryNode<T>(rootItem, null, t2.root);
            }
            else if (t2 == null)
            {
                root = new BinaryNode<T>(rootItem, t1.root, null);
            }
            else
            {
                root = new BinaryNode<T>(rootItem, t1.root, t2.root);
            }
        }

        public string ToPrefixString()
        {
            if (root == null)
            {
                return "NIL";
            }
            return CreatePrefixString(root, "[ ") + "]";
        }

        public string CreatePrefixString(BinaryNode<T> node, string prefixString)
        {
            prefixString += $"{node.data} ";
            if (node.left != null)
            {
                prefixString += "[ ";
                prefixString = CreatePrefixString(node.left, prefixString) + "] ";
            }
            else
            {
                prefixString += "NIL ";
            }

            if (node.right != null)
            {
                prefixString += "[ ";
                prefixString = CreatePrefixString(node.right, prefixString) + "] ";
            }
            else
            {
                prefixString += "NIL ";
            }

            return prefixString;
        }

        public string ToInfixString()
        {
            if (root == null)
            {
                return "NIL";
            }
            return CreateInfixString(root, "[ ") + "]";
        }

        public string CreateInfixString(BinaryNode<T> node, string infixfixString)
        {
            if (node.left != null)
            {
                infixfixString += "[ ";
                infixfixString = CreateInfixString(node.left, infixfixString) + "] ";
            }
            else
            {
                infixfixString += "NIL ";
            }

            infixfixString += $"{node.data} ";

            if (node.right != null)
            {
                infixfixString += "[ ";
                infixfixString = CreateInfixString(node.right, infixfixString) + "] ";
            }
            else
            {
                infixfixString += "NIL ";
            }
            return infixfixString;
        }

        public string ToPostfixString()
        {
            if (root == null)
            {
                return "NIL";
            }
            return CreatePostfixString(root, "[ ") + "]";
        }

        public string CreatePostfixString(BinaryNode<T> node, string postfixString)
        {
            if (node.left != null)
            {
                postfixString += "[ ";
                postfixString = CreatePostfixString(node.left, postfixString) + "] ";
            }
            else
            {
                postfixString += "NIL ";
            }

            if (node.right != null)
            {
                postfixString += "[ ";
                postfixString = CreatePostfixString(node.right, postfixString) + "] ";
            }
            else
            {
                postfixString += "NIL ";
            }
            return postfixString += $"{node.data} "; ;
        }

        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            int leaves = 0;
            if (root != null)
            {
                return CalculateLeaves(root, leaves);
            }
            return leaves;
        }

        public int CalculateLeaves(BinaryNode<T> node, int totalLeaves)
        {
            if (node.left == null && node.right == null)
            {
                return totalLeaves + 1;
            }

            if (node.left != null)
            {
                totalLeaves = CalculateLeaves(node.left, totalLeaves);
            }
            if (node.right != null)
            {
                totalLeaves = CalculateLeaves(node.right, totalLeaves);
            }
            return totalLeaves;
        }

        public int NumberOfNodesWithOneChild()
        {
            int oneChildren = 0;
            if (root != null)
            {
                return CalculateOneChild(root, oneChildren);
            }
            return oneChildren;
        }

        public int CalculateOneChild(BinaryNode<T> node, int totalOneChild)
        {
            if (node.left != null && node.right == null || node.left == null && node.right != null)
            {
                totalOneChild++;
            }

            if (node.left != null)
            {
                totalOneChild = CalculateOneChild(node.left, totalOneChild);
            }
            if (node.right != null)
            {
                totalOneChild = CalculateOneChild(node.right, totalOneChild);
            }
            return totalOneChild;
        }

        public int NumberOfNodesWithTwoChildren()
        {
            int twoChildren = 0;
            if (root != null)
            {
                return CalculateTwoChildren(root, twoChildren);
            }
            return twoChildren;
        }

        public int CalculateTwoChildren(BinaryNode<T> node, int totalTwoChildren)
        {
            if (node.left != null && node.right != null)
            {
                totalTwoChildren += 1;
            }

            if (node.left != null)
            {
                totalTwoChildren = CalculateTwoChildren(node.left, totalTwoChildren);
            }
            if (node.right != null)
            {
                totalTwoChildren = CalculateTwoChildren(node.right, totalTwoChildren);
            }
            return totalTwoChildren;
        }
    }
}