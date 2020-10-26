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

            int n1 = center - left + 1;
            int n2 = right - center;

            for (int l = 0; l < n1; l++)
            {
                leftArray.Add(list[left + l]);
            }

            for (int r = 0; r < n2; r++)
            {
                rightArray.Add(list[center + r + 1]);
            }

            int i = 0;
            int j = 0;
            int a = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    list[a] = leftArray[i];
                    i++;
                }
                else
                {
                    list[a] = rightArray[j];
                    j++;
                }
                a++;
            }

            while(i < n1)
            {
                list[a] = leftArray[i];
                i++;
                a++;
            }

            while (j < n2)
            {
                list[a] = rightArray[j];
                j++;
                a++;
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