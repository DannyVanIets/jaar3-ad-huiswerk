using System.Collections.Generic;


namespace AD
{
    public partial class ShellSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            for (int increment = list.Count / 2; increment > 0; increment /= 2)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int arrayPlace = i;

                    for (int j = i + increment; j < list.Count; j += increment, arrayPlace += increment)
                    {
                        int temporary = list[arrayPlace];

                        if (list[j] <= temporary)
                        {
                            list[arrayPlace] = list[j];
                            list[j] = temporary;
                        }
                    }
                }

                if(list[1] < list[0]) // Temporary fix.
                {
                    int temp = list[1];
                    list[1] = list[0];
                    list[0] = temp;
                }
            }
        }
    }
}