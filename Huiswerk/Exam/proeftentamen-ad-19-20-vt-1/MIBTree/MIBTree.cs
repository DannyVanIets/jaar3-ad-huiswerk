namespace AD
{
    public class MIBTree : BinarySearchTree<MIBNode>
    {
        public MIBTree()
        {
            Insert(new MIBNode("1.3.6.1.4.1.9", "cisco"));
            Insert(new MIBNode("1.3.6.1.1.1.1", "system"));
            Insert(new MIBNode("1.3.6", "dod"));
            Insert(new MIBNode("1.3.6.1.1.1.4", "ip"));
            Insert(new MIBNode("1.3.6.1.3", "experimental"));
            Insert(new MIBNode("1.3.6.1.4.1", "enterprise"));
            Insert(new MIBNode("1.3.6.1.1.1.2", "interfaces"));
            Insert(new MIBNode("1.3.6.1.1", "directory"));
            Insert(new MIBNode("1.3", "org"));
            Insert(new MIBNode("1.3.6.1.4.1.2636", "juniperMIB"));
            Insert(new MIBNode("1.3.6.1.4.1.311", "microsoft"));
            Insert(new MIBNode("1.3.6.1", "internet"));
            Insert(new MIBNode("1", "iso"));
            Insert(new MIBNode("1.3.6.1.4", "private"));
            Insert(new MIBNode("1.3.6.1.1.1", "mib-2"));
            Insert(new MIBNode("1.3.6.1.2", "mgmt"));
        }

        public MIBNode FindNode(string oid)
        {
            if (root != null)
            {
                BinaryNode<MIBNode> currentNode = root;
                while (currentNode != null)
                {
                    if (currentNode.data.oid == oid)
                    {
                        return currentNode.data;
                    }
                    else if (oid.CompareTo(currentNode.data.oid) < 0 && currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    else if (oid.CompareTo(currentNode.data.oid) > 0 && currentNode.right != null)
                    {
                        currentNode = currentNode.right;
                    }
                    else
                    {
                        currentNode = null;
                    }
                }
            }
            return null;
        }

        public bool AllNodesAvailable(string oid)
        {
            bool result = false;
            if (FindNode(oid) != null)
            {
                // This will take everything of the string before the last .
                int length = oid.LastIndexOf(".");

                // base case
                if(length <= 0)
                {
                    return true;
                }

                // This will shorten the string everytime, making it recursive.
                result = AllNodesAvailable(oid.Substring(0, length));
            }
            return result;
        }
    }
}
