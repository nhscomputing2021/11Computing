using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //test GenerateRandArray method
            int arrSize = 10;
            int[] randArr = GenerateRandArray(arrSize);
            Console.WriteLine(string.Join(" ",randArr));

            //test the evenNumbersCount method and output the result
            int count = evenNumbersCount(randArr);
            Console.WriteLine($"There are {count} even numbers.");

            //test getfilename method
            string[] paths = {"c:/mycomputer/documents/password.txt","d:/flash/songs/countonme.mp3" };
            Console.WriteLine(string.Join(",", GetFileName(paths)));

            //test the task 5
            Console.WriteLine(LongestAbecedarian(new string[] { "ace", "spades", "hearts", "clubs" }));
            Console.WriteLine(LongestAbecedarian(new string[] { "forty", "choppy", "ghost" }));
            Console.WriteLine(LongestAbecedarian(new string[] { "one", "two", "three" }));


        }

        static int[] GenerateRandArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }

            return arr;
        }

        static int evenNumbersCount(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count += 1;
                }
            }

            return count;
        }

        static List<string> GetFileName(string[] paths)
        {
            List<string> fileNames = new List<string> { };

            for (int i = 0; i < paths.Length; i++)
            {
                fileNames.Add(paths[i].Split("/").Last());
            }
           
            return fileNames;
        }

        static string LongestAbecedarian(string[] words)
        {
            string result;

            Dictionary<string, int> abWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                char[] letters = word.ToCharArray();

                Array.Sort(letters);

                if (string.Join("",letters) == word)

                {
                    abWords.Add(word,word.Length);
                }
            }

            if (abWords.Count != 0)
            {
                result = abWords.OrderByDescending(x => x.Value).First().Key;
            }
            else
            {
                result = "nothing found";
            }
            
            return result;
        }
    }
}
