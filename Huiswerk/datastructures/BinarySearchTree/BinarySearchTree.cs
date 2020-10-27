namespace AD
{
    public partial class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : System.IComparable<T>
    {

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x)
        {
            if (root == null)
            {
                root = new BinaryNode<T>(x, null, null);
            }
            else
            {
                BinaryNode<T> currentNode = root;
                BinaryNode<T> parent = new BinaryNode<T>();

                while (currentNode != null)
                {
                    parent = currentNode;

                    // With the CompareTo() we can check the values of generics.
                    // If x is lower than zero, it's lower and if it's higher than zero, x is higher.
                    // If x is equel to zero, then it's the same!
                    if (x.CompareTo(currentNode.data) < 0 && currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    else if (x.CompareTo(currentNode.data) > 0 && currentNode.right != null)
                    {
                        currentNode = currentNode.right;
                    }
                    else if (x.CompareTo(currentNode.data) == 0)
                    {
                        throw new BinarySearchTreeDoubleKeyException();
                    }
                    else
                    {
                        currentNode = null;
                    }
                }

                if (x.CompareTo(parent.data) < 0)
                {
                    parent.left = new BinaryNode<T>(x, null, null);
                }
                else if (x.CompareTo(parent.data) > 0)
                {
                    parent.right = new BinaryNode<T>(x, null, null);
                }
            }
        }

        public T FindMin()
        {
            if (root == null)
            {
                throw new BinarySearchTreeEmptyException();
            }
            else
            {
                BinaryNode<T> currentNode = root;
                BinaryNode<T> parent = new BinaryNode<T>();

                while (currentNode != null)
                {
                    parent = currentNode;
                    if (currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = null;
                    }
                }
                return parent.data;
            }
        }

        public void RemoveMin()
        {
            if (root == null)
            {
                throw new BinarySearchTreeEmptyException();
            }
            else if (root.left == null && root.right == null)
            {
                root = null;
            }
            else
            {
                BinaryNode<T> currentNode = root;

                while (currentNode.left != null)
                {
                    if (currentNode.left.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    // In this if statement we check if there's something to the right of the smallest node.
                    // If that's the case, we will replace the smallest node with what's of the right of it.
                    else if (currentNode.left.right != null)
                    {
                        currentNode.left = currentNode.left.right;
                        break;
                    }
                    else
                    {
                        currentNode.left = null;
                    }
                }
            }
        }

        public void Remove(T x)
        {
            if (root == null)
            {
                throw new BinarySearchTreeElementNotFoundException();
            }
            else if (root.left == null && root.right == null)
            {
                root = null;
            }
            else
            {
                BinaryNode<T> currentNode = root;
                BinaryNode<T> parent = new BinaryNode<T>();

                while (currentNode != null)
                {
                    if (x.CompareTo(currentNode.data) == 0)
                    {
                        // willReplace is de node/data die de te vervangen node gaat overnemen.
                        BinaryNode<T> willReplace = new BinaryNode<T>();

                        // De node die je wilt verwijderen heeft twee children
                        if (currentNode.left != null && currentNode.right != null)
                        {
                            // toDelete is de uiteindelijke node die we willen weghalen.
                            willReplace = currentNode.right;
                            parent = currentNode;
                            BinaryNode<T> toDelete = currentNode;

                            // We maken een loop door de linkerkant om het kleinste node daarin te vinden.
                            // De data van deze node wordt uiteindelijk de data van de te verwijderen node.
                            while (willReplace.left != null)
                            {
                                parent = willReplace;
                                willReplace = willReplace.left;
                            }

                            toDelete.data = willReplace.data;

                            // Als de willReplace nog wat heeft staan aan de rechterkant, willReplace vervangen daardoor.
                            if (willReplace.right != null)
                            {
                                parent.right = willReplace.right;
                            }
                            // Verwijder de oude node, zodat er geen dubbele waardes zijn, zolang het geen kinderen heeft!
                            else
                            {
                                parent.right = null;
                            }
                            break;
                        }
                        // Node heeft een child aan de linkerkant
                        else if (currentNode.left != null)
                        {
                            willReplace = currentNode.left;
                        }
                        // Node heeft een child aan de rechterkant
                        else if (currentNode.right != null)
                        {
                            willReplace = currentNode.right;
                        }
                        // De node heeft geen children.
                        else
                        {
                            willReplace = null;
                        }

                        // Hier gaan we de verbinding naar de node verbreken of vervangen.
                        if (parent.left == currentNode)
                        {
                            parent.left = willReplace;
                        }
                        else if (parent.right == currentNode)
                        {
                            parent.right = willReplace;
                        }
                        break;
                    }
                    else if (x.CompareTo(currentNode.data) < 0 && currentNode.left != null)
                    {
                        parent = currentNode;
                        currentNode = currentNode.left;
                    }
                    else if (x.CompareTo(currentNode.data) > 0 && currentNode.right != null)
                    {
                        parent = currentNode;
                        currentNode = currentNode.right;
                    }
                    else
                    {
                        throw new BinarySearchTreeElementNotFoundException();
                    }
                }
            }
        }

        public string InOrder()
        {
            string inOrderString = "";
            inOrderString = InOrderString(root, inOrderString);
            // Simplified version of: inOrderString.Substring(0, inOrderString.Length - 1);
            return inOrderString[0..^1];
        }

        public string InOrderString(BinaryNode<T> node, string inOrderString)
        {
            if (node != null)
            {
                inOrderString = InOrderString(node.left, inOrderString);
                inOrderString += $"{node.data} ";
                inOrderString = InOrderString(node.right, inOrderString);
            }
            return inOrderString;
        }

        public override string ToString()
        {
            if (root == null)
            {
                return "";
            }
            else
            {
                return InOrder();
            }
        }
    }
}