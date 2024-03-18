namespace GA_BubbleSort_TylerSimpson
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int size = 10; // Change the size of the array as needed
            int minValue = 1; // Change the minimum value as needed
            int maxValue = 100; // Change the maximum value as needed

            int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);

            //Display your array in it's unsorted form
            DisplayArray(randomArray);
            Console.WriteLine("\n");
            // Call your bubble sort method
            BubbleSort(randomArray);
            // Display your method after its been sorted
            DisplayArray(randomArray);
        }
        static void DisplayArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
        }
        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            if (size <= 0 || minValue > maxValue)
            {
                throw new ArgumentException("Invalid arguments");
            }

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }

        public static void BubbleSort(int[] arr)
        {
            int arrayLength = arr.Length;
            bool hasSwapped;

            //this loop goes through the array, and brings the largest element to the end of the array aka "bubbles" it up to its correct position
            for (int currentPass = 0; currentPass < arrayLength - 1; currentPass++)
            {
                hasSwapped = false;
                //- Inner Loop starts at the first array index of 0 and compares adjacent elements in the array, swapping or "bubbling up" if in wrong order 
                for (int currentIndex = 0; currentIndex < arrayLength - 1 - currentPass; currentIndex++)
                {
                    //Condition is checking if the currentIndex is greater than the next element in the array which determines if swapping the two elements is necessary
                    //if the conditions are true, then the swap is preformed. 
                    if (arr[currentIndex] > arr[currentIndex + 1])
                    {
                        // Swapping Algorithm

                        // Store the value of the element at currentIndex in a temporary variable called temp
                        int temp = arr[currentIndex];

                        // Replace the value at currentIndex with the value of the next element (currentIndex + 1)
                        arr[currentIndex] = arr[currentIndex + 1];

                        // Assign the original value (stored in temp) back to the next element, completing the swap
                        arr[currentIndex + 1] = temp;

                        hasSwapped = true;
                    }                    
                }
                // If no two elements were swapped in the inner loop, the array is already sorted
                if (!hasSwapped)
                {
                    break;
                }
            }
        }
    }
}
