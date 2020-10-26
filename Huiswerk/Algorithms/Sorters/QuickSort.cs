using System.Collections.Generic;


namespace AD
{
    public partial class QuickSort : Sorter
    {
        private static int CUTOFF = 3;
        private static InsertionSort insertionSort = new InsertionSort();

        private void SwapElements(List<int> list, int firstIndexToSwap, int lastIndexToSwap)
        {
            int temporaryNumber = list[firstIndexToSwap];
            list[firstIndexToSwap] = list[lastIndexToSwap];
            list[lastIndexToSwap] = temporaryNumber;
        }

        private void Quicksort(List<int> list, int low, int high)
        {
            // CUTOFF wordt gebruikt voor als er zo weinig waardes in de array staan dat het niet de tijd waard is om
            // met quicksort het te sorteren. Dan kunnen we beter insertionsort gebruiken
            if (low + CUTOFF > high)
            {
                insertionSort.SortWithCutoff(list, low, high);
            }
            else
            {
                int center = (low + high) / 2;
                // Sorteer het 1ste, het middelste en het laatste getal op de goede volgorde alvast.
                if (list[center] < list[low])
                {
                    SwapElements(list, low, center);
                }
                if (list[high] < list[low])
                {
                    SwapElements(list, low, high);
                }
                if (list[high] < list[center])
                {
                    SwapElements(list, center, high);
                }

                // Verwissel de pivot met laatste getal. Dus wat op de plek list.count - 1 staat
                SwapElements(list, center, high);
                int pivot = list[high];

                int i;
                int j;

                for (i = low, j = high - 1; ;)
                {
                    // int i blijft loopen totdat er een getal is gevonden die groter is dan de pivot.
                    while (list[i] < pivot)
                    {
                        i++;
                    }
                    // int j blijft loopen totdat er een getal is gevonden die kleiner is dan de pivot.
                    while (list[j] > pivot)
                    {
                        j--;
                    }
                    if (i >= j)
                    {
                        break;
                    }
                    SwapElements(list, i, j);
                }

                //Pivot zetten op de plek tussen de twee lijsten.
                SwapElements(list, i, high);

                //Alles wat aan de linker kant van de pivot staat sorteren.
                Quicksort(list, low, i - 1);
                //Alles wat aan de rechter kant van de pivot staat sorteren.
                Quicksort(list, i + 1, high);
            }
        }

        public override void Sort(List<int> list)
        {
            Quicksort(list, 0, list.Count - 1);
        }
    }
}
