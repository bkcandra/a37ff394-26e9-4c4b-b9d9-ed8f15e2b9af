namespace GetLIS.Services
{
    public static class LISService
    {
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
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                        lisIndex = i + 1 - currentLength;
                    }
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
