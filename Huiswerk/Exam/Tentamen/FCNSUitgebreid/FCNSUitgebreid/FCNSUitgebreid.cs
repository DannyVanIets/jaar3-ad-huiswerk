namespace AD
{
    public partial class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public IFCNSNode<T> FindParent(T data)
        {
            // Je mag aannemen dat "data" in de boom zit en uniek is
            if (data != null && !root.data.Equals(data))
            {
                return FindNode(data, root, root);
            }
            return null;
        }

        public FCNSNode<T> FindNode(T data, FCNSNode<T> parentNode, FCNSNode<T> currentNode)
        {
            if (parentNode.firstChild != null && data.Equals(parentNode.firstChild.data))
            {
                return parentNode;
            }
            else if (parentNode.nextSibling != null && data.Equals(parentNode.nextSibling.data))
            {
                return parentNode;
            }
            else if (parentNode.secondSibling != null && data.Equals(parentNode.secondSibling.data))
            {
                return parentNode;
            }
            else
            {
                if (currentNode.firstChild != null)
                {
                    parentNode = FindNode(data, currentNode, currentNode.firstChild);
                }
                if (currentNode.nextSibling != null)
                {
                    parentNode = FindNode(data, parentNode, currentNode.nextSibling);
                }
                if (currentNode.secondSibling != null)
                {
                    parentNode = FindNode(data, parentNode, currentNode.secondSibling);
                }
            }
            return parentNode;
        }

        public string SiblingsToString(T data)
        {
            // Je mag aannemen dat "data" in de boom zit en uniek is

            string allSiblings = $"Siblings of {data.ToString()}: ";
            FCNSNode<T> parent = (FCNSNode<T>)FindParent(data);

            if (parent != null)
            {
                if (parent.GetFirstChild() != null && !parent.GetFirstChild().GetData().Equals(data))
                {
                    allSiblings += $"{parent.GetFirstChild().GetData().ToString()} ";
                }
                if (parent.GetNextSibling() != null && !parent.GetNextSibling().GetData().Equals(data))
                {
                    allSiblings += $"{parent.GetNextSibling().GetData().ToString()} ";
                }
                if (parent.secondSibling != null && !parent.secondSibling.GetData().Equals(data))
                {
                    allSiblings += $"{parent.secondSibling.GetData().ToString()} ";
                }
            }
            return allSiblings;
        }
    }

}