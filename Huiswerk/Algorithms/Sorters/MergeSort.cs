using System;
using System.Collections.Generic;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public void Merge(List<int> list, int left, int center, int right)
        {
            List<int> leftArray = new List<int>();
            List<int> rightArray = new List<int>();

            for (int l = 0; l < center; l++)
            {
                leftArray.Add(list[l]);
            }

            for (int r = center; r < list.Count; r++)
            {
                rightArray.Add(list[r]);
            }

            int i = 0;
            int j = 0;

            for (int m = left; m < right + 1; m++)
            {
                if (i == leftArray.Count)
                {
                    list[m] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Count)
                {
                    list[m] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    list[m] = leftArray[i];
                    i++;
                }
                else
                {
                    list[m] = rightArray[j];
                    j++;
                }
            }
        }

        public void Mergesort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;

                Mergesort(list, left, center); // For left-side of the array.
                Mergesort(list, center + 1, right); // For right-side of the array.
                Merge(list, left, center, right);
            }
        }

        public override void Sort(List<int> list)
        {
            if (list.Count > 0)
            {
                Mergesort(list, 0, list.Count - 1);
            }
        }
    }
}