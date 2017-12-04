using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Info> transactions = new List<Info>();

            using (var RD = new StreamReader(@"C:\Work\FurtherCsharp\StringsExerciseone\StringsExercise1\StringsExerciseOne\strings.txt"))
            {
                while (!RD.EndOfStream)
                {
                    var splits = RD.ReadLine().Split(',');
                    var info = new Info(splits[0], splits[1], splits[2]);

                    transactions.Add(info);
                }

            }

            Console.WriteLine("Book Information \n");

            foreach (var info in transactions)
            {
                if (info.Title.Length > 26)
                {
                    int maxLength = 26;
                    info.Title = info.Title.Substring(0, maxLength - 3) + "...";
                }
                if (info.Author.Length > 31)
                {
                    int maxLength = 31;
                    info.Author = info.Author.Substring(0, maxLength - 3) + "...";
                }
                Console.WriteLine("|{0}|{1}|{2}|", info.Date, info.Title, info.Author);
            }
            Console.ReadLine();
        }

        public string TruncString(string Title, int Threshold)
        {
            if (Title.Length > 10)
                return Title.Substring(0, Threshold) + "...";
            return Title;
        }
    }
}
