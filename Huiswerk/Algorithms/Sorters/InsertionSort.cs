using System.Collections.Generic;


namespace AD
{
    public partial class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int temporary = list[i];

                for (int j = 0; j < i; j++)
                {
                    if (list[i] <= list[j])
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