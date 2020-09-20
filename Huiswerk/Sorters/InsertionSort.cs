using System.Collections.Generic;


namespace AD
{
    public partial class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
           for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = 0; j < list.Count - 1; j++)
                {
                    if(list[i] < list[j])
                    {

                    }
                }
            }
        }
    }
}
