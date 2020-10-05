using System.Collections.Generic;

namespace AD
{
    public class Opgave6
    {
        public static string ForwardString(List<int> list, int from)
        {
            if (list.Count == 0)
            {
                return "";
            }
            else if (from == 0)
            {
                return $"{list[0]} " + ForwardString(list.GetRange(1, list.Count - 1), from);
            }
            else
            {
                list.RemoveAt(0);
                return ForwardString(list, from - 1);
            }
        }

        public static string BackwardString(List<int> list, int to)
        {
            if (list.Count == 0)
            {
                return "";
            }
            else if (to == 0)
            {
                return $"{list[0]} " + BackwardString(list.GetRange(1, list.Count - 1), to);
            }
            else
            {
                list.RemoveAt(list.Count - to);
                return BackwardString(list, to - 1);
            }
        }

        public static void Run()
        {
            List<int> list = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            System.Console.WriteLine(ForwardString(list, 3));
            System.Console.WriteLine(ForwardString(list, 7));
            System.Console.WriteLine(BackwardString(list, 3));
            System.Console.WriteLine(BackwardString(list, 7));
        }
    }
}