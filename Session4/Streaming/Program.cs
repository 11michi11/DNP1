using System;
using System.IO;

namespace Streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("words: " + GetWordsCount());
            Console.WriteLine("Longest: " + GetTheLongestWord());
        }


        public static int GetWordsCount()
        {
            try
            {   
                using (StreamReader sr = new StreamReader("file.txt"))
                {
                    String line = sr.ReadToEnd();
                    var words = line.Split(" ");
                    return words.Length;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static String GetTheLongestWord()
        {
            try
            {   
                using (StreamReader sr = new StreamReader("file.txt"))
                {
                    String line = sr.ReadToEnd();
                    var words = line.Split(" ");

                    int maxLen = 0;
                    var longestWord = "";

                    foreach (var word in words)
                    {
                        if (word.Length > maxLen)
                        {
                            longestWord = word;
                            maxLen = word.Length;
                        }
                    }

                    return longestWord;
                }
            }
            catch (Exception e)
            {
                return "";
            }
        }
        
    }
}