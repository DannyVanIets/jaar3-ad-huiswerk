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
                insertionSort.Sort(list);
            }
            else
            {
                int center = (low + high) / 2;
                // Sorteer het 1ste, het middelste en het laatste getal op de goede volgorde alvast.
                // CompareTo gebruiken we om te kijken of bijvoorbeeld het middelste getal kleiner is dan het laagste getal.
                if (list[center].CompareTo(list[low]) < 0)
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

                // Verwissel de pivot met de 1na laatste getal. Dus wat op de plek list.count - 1 staat
                SwapElements(list, center, high - 1);
                int pivot = list[high - 1];

                int i;
                int j;

                for (i = low, j = high - 1; ;)
                {
                    // int i kijkt altijd of getal in de lijst kleiner is dan de pivot.
                    while (list[i++] < pivot)
                    {

                    }
                    // int j kijkt altijd of het getal in de lijst groter is dan de pivot.
                    while (list[j--] > pivot)
                    {

                    }
                    if (i >= j)
                    {
                        break;
                    }
                    SwapElements(list, i, j);
                }

                //Pivot zetten op de plek tussen de twee lijsten.
                SwapElements(list, i, high - 1);

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
