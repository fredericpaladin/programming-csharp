namespace Algorithms.Sorting
{
    public static class Quicksort
    {
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                // Array of 1 element
                return;
            }

            int pivotIndex = endIndex;
            int pivot = array[pivotIndex];
            int leftPointer = startIndex;
            int rightPointer = endIndex;

            while (leftPointer != rightPointer)
            {
                // Move the left pointer to the right until we find a number greater than the pivot
                // Or the pointers meet
                while (array[leftPointer] <= pivot && leftPointer != rightPointer)
                {
                    leftPointer++;
                }

                // Move the right pointer to the left until we find a number less than the pivot
                // Or the pointers meet
                while (array[rightPointer] >= pivot && leftPointer != rightPointer)
                {
                    rightPointer--;
                }

                // Swap the items at the pointers
                Swap(array, leftPointer, rightPointer);
            }

            // Swap the pivot with the item at the left pointer
            Swap(array, leftPointer, pivotIndex);

            // Partition the array into 2 sub-arrays and recursevely repeat the process
            Sort(array, startIndex, leftPointer - 1);
            Sort(array, rightPointer + 1, endIndex);
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            if (index1 == index2)
                return;

            int item1 = array[index1];
            array[index1] = array[index2];
            array[index2] = item1;
        }
    }
}
