namespace GetLIS.Services
{
    /// <summary>
    /// Represent LIS Service 
    /// </summary>
    public static class LisService
    {

        /// <summary>
        /// Calculates the Longest Increasing Subsequence (LIS) from a given array of integers and returns it as a space-separated string.
        /// The LIS is the longest subsequence where each element is greater than its predecessor.
        /// </summary>
        /// <param name="intArray">The input string containing numbers separated by spaces.</param>
        /// <returns>A string representing the LIS, with each element of the subsequence separated by a space.</returns>
        public static string GetLISfromString(string inputString)
        {
            if (inputString == string.Empty)
                return "";

            if (!ConvertToIntArray(inputString, out int[] intArray))
            {
                return "Invalid input. Please enter a valid sequence of numbers.";
            }

            var lisIndex = 0;
            var maxLength = 1;
            var currentLength = 1;

            for (var i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > intArray[i - 1])
                {
                    currentLength++;
#pragma warning disable S2589 // Max length will be changed as we iterate the array and updated when LIS is found.
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                        lisIndex = i + 1 - currentLength;
                    }
#pragma warning restore S2589
                }
                else
                {
                    currentLength = 1;
                }
            }

            int[] subArray = new int[maxLength];
            Array.Copy(intArray, lisIndex, subArray, 0, maxLength);
            return string.Join(" ", subArray);
        }

        /// <summary>
        /// Converts a space-separated string of numbers into an array of integers.
        /// </summary>
        /// <param name="inputString">The input string containing numbers separated by spaces.</param>
        /// <param name="listInt">The output array of integers, populated if the conversion is successful.</param>
        /// <returns>
        /// True if the conversion is successful, meaning all elements in the input string are valid integers.
        /// If any element in the input string cannot be converted to an integer, the method returns false and sets listInt to an empty array.
        /// </returns>
        public static bool ConvertToIntArray(string inputString, out int[] listInt)
        {
            var tempInts = new List<int>();

            foreach (var str in inputString.Split(' '))
            {
                if (str == string.Empty)
                    continue;

                if (int.TryParse(str, out int num))
                {
                    tempInts.Add(num);
                }
                else
                {
                    listInt = Array.Empty<int>();
                    return false;
                }
            }
            listInt = tempInts.ToArray();
            return true;
        }
    }
}
