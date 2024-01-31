namespace GetLIS.Services
{
    public static class LISService
    {
        public static string GetLISfromString(string inputString)
        {
            return "";
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
