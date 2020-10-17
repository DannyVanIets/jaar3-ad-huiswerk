using System.Collections.Generic;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public void Merge(List<int> list, int left, int center, int right)
        {


            List<int> leftArray = list[left, center];
        }

        public void Mergesort(List<int> list, int left, int right)
        {
            if(left < right)
            {
                int center = (left + right) / 2;

                Mergesort(list, left, center); // For left-side of the array.
                Mergesort(list, center + 1, right); // For right-side of the array.
                Merge(list, left, center, right);
            }
        }

        public override void Sort(List<int> list)
        {
            if(list.Count > 0)
            {
                Mergesort(list, 0, list.Count - 1);
            }
        }
    }
}