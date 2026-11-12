using System;

namespace QuickSort
{
    public class QuickSort
    {
        public static int OperationCount = 0;
        public static int SwapCount = 0;

        public static void Sort<T>(T[] array) where T : IComparable
        {
            if (array == null || array.Length < 2)
                return;

            Sort(array, 0, array.Length - 1);
        }

        private static void Sort<T>(T[] array, int left, int right) where T : IComparable
        {
            // Para quando há zero ou um elemento: não há nada para ordenar
            if (left >= right)
                return;

            int pivotIndex = Partition(array, left, right);

            // Ordena recursivamente o subarray inferior e o superior
            Sort(array, left, pivotIndex);
            Sort(array, pivotIndex + 1, right);
        }

        // Partição de Hoare com o primeiro elemento como pivô
        private static int Partition<T>(T[] array, int left, int right) where T : IComparable
        {
            T pivot = array[left];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                // Avança i até achar um valor >= pivô
                do
                {
                    i++;
                    OperationCount++;
                } while (array[i].CompareTo(pivot) < 0);

                // Recua j até achar um valor <= pivô
                do
                {
                    j--;
                    OperationCount++;
                } while (array[j].CompareTo(pivot) > 0);

                if (i >= j)
                    return j;

                Swap(array, i, j);
            }
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            SwapCount++;
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}