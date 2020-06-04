using System;

namespace Lab_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввести строку : ");
            string str = Console.ReadLine();
            string[] split = str.Split(new char[] { ' ', ',', ':', ';', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int minLength = Int32.MaxValue;
            string smallestWord = String.Empty;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Length < minLength)
                {
                    minLength = split[i].Length;
                    smallestWord = split[i];
                    if (minLength == 1)
                        break;
                }
            }
            Console.WriteLine(smallestWord);
        }
    }
}
