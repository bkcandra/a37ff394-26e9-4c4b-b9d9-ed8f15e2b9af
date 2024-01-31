using GetLIS.Services;

namespace GetLIS
{
    internal static class Program
    {
        /// <summary>
        /// Continuously prompts the user to input a sequence of numbers separated by spaces.
        /// Calculates and displays the longest increasing subsequence for each valid input.
        /// application will runs in a loop and can be exited by entering 'exit'.
        /// </summary>
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a sequence of numbers separated by spaces ('exit' to quit):");
                string input = Console.ReadLine() ?? "";

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.WriteLine(LisService.GetLISfromString($"{input}\n"));
                Console.WriteLine(); // adding space for readability
            }
        }
    }
}