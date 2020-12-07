using System;

namespace AD
{
    class Program
    {
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //
        // In de opgave staat dat hier de method
        //    FirstChildNextSibling<int> CreateFirstChildNextSibling_Practicum()
        // gemaakt moet worden.
        // Dit is een foutje. Implementeer in plaats daarvan de method
        //    IFirstChildNextSibling<int> CreateFirstChildNextSibling_Practicum()
        // in FCNSUitgebreidBuilder.cs
        // 
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        static void Main(string[] args)
        {
            // Part a
            IFirstChildNextSibling<int> tree = DSBuilder.CreateFirstChildNextSibling_Practicum();

            // Part b
            // -- your test code --
            int treesize = tree.Size();
            for (int i = 1; i <= treesize; i++)
            {
                IFCNSNode<int> parent = tree.FindParent(i);
                if (parent == null)
                {
                    Console.WriteLine($"Parent of {i}: null");
                }
                else
                {
                    Console.WriteLine($"Parent of {i}: {parent.GetData().ToString()}");
                }
            }



            // Part c
            // -- your test code --

            for (int i = 1; i <= treesize; i++)
            {
                Console.WriteLine($"{tree.SiblingsToString(i)}");
            }
        }
    }
}