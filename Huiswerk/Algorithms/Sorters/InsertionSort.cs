using System.Collections.Generic;


namespace AD
{
    public partial class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int temporary = list[i];

                for (int j = 0; j < i; j++)
                {
                    if (list[i] < list[j])
                    {
                        list[i] = list[j];
                        list[j] = temporary;
                        temporary = list[i];
                    }
                }
            }
        }

        public void SortWithCutoff(List<int> list, int low, int high)
        {
            for (int i = low; i <= high; i++)
            {
                int temporary = list[i];

                for (int j = high; j > i; j--)
                {
                    if (list[i] > list[j])
                    {
                        list[i] = list[j];
                        list[j] = temporary;
                        temporary = list[i];
                    }
                }
            }
        }
    }
}