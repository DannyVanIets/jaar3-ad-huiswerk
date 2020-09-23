using System.Collections.Generic;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public void Mergesort(List<int> list, int startingPoint, int amount)
        {
            List<int> tempArrayA = new List<int>();
            List<int> tempArrayB = new List<int>();

            // In here we insert what we are gonna split up.
            tempArrayA = list.GetRange(startingPoint, amount / 2);
            tempArrayB = list.GetRange(amount / 2, amount);

            // Sort what's in the arrays.
            int leftCount = 0;
            int rightCount = 0;

            /*for (int i = 0; i <= amount; i++)
            {
                if (tempArrayLeft[leftCount] < tempArrayRight[rightCount])
                {
                    temporaryList.Add(tempArrayLeft[leftCount]);
                    leftCount++;
                }
                else
                {
                    temporaryList.Add(tempArrayLeft[rightCount]);
                    rightCount++;
                }
            }*/
        }

        public override void Sort(List<int> list)
        {
            if(list.Count > 0)
            {
                int center = list.Count / 2;

                Mergesort(list, 0, center); // For left array.
                Mergesort(list, center, list.Count - center); // For right array.

                //List<int> tempArrayLeft = list.GetRange(startingPoint, center);
                //List<int> tempArrayRight = list.GetRange(center, list.Count - center);

                /*if (center / 2 == 0) // Extra getal voor nu zodat hij niet vastloopt.
                {
                    tempArrayRight.Add(0);
                }

                
                
                list = temporaryList;*/
            }
        }
    }
}