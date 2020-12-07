namespace AD
{
    public partial class DSBuilder
    {
        public static IFirstChildNextSibling<int> CreateFirstChildNextSibling_Practicum()
        {
            FirstChildNextSibling<int> tree = new FirstChildNextSibling<int>();

            FCNSNode<int> n5 = new FCNSNode<int>(5);
            FCNSNode<int> n2 = new FCNSNode<int>(2, n5, null);

            FCNSNode<int> n3 = new FCNSNode<int>(3, null, null);

            FCNSNode<int> n6 = new FCNSNode<int>(6, null, null);
            FCNSNode<int> n7 = new FCNSNode<int>(7, null, null);
            FCNSNode<int> n8 = new FCNSNode<int>(8, null, null);
            FCNSNode<int> n4 = new FCNSNode<int>(4, n6, n7, n8);

            FCNSNode<int> n1 = new FCNSNode<int>(1, n2, n3, n4);

            tree.root = n1;

            return tree;
        }
    }
}
