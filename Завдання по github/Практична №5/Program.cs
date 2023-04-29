using System;
using System.Collections.Generic;

namespace ProgramList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> programs = new Dictionary<int, string>();
            programs.Add(1, "Google Chrome");
            programs.Add(2, "Mozilla Firefox");
            programs.Add(3, "Apple Safari");
            programs.Add(4, "Microsoft Edge");
            programs.Add(5, "Microsoft Visual Studio");
            programs.Add(6, "Eclipse");
            programs.Add(7, "IntelliJ IDEA");
            programs.Add(8, "PyCharm");

            Dictionary<string, List<string>> authors = new Dictionary<string, List<string>>();
            authors.Add("Google", new List<string>() { "Google Chrome" });
            authors.Add("Mozilla", new List<string>() { "Mozilla Firefox" });
            authors.Add("Apple", new List<string>() { "Apple Safari" });
            authors.Add("Microsoft", new List<string>() { "Microsoft Edge", "Microsoft Visual Studio" });
            authors.Add("Eclipse Foundation", new List<string>() { "Eclipse" });
            authors.Add("JetBrains", new List<string>() { "IntelliJ IDEA", "PyCharm" });

            Console.WriteLine("Список програмних продуктів:");
            foreach (KeyValuePair<int, string> program in programs)
            {
                Console.WriteLine(program.Key + " - " + program.Value);
            }

            Console.WriteLine("Введіть номери програмних продуктів через кому:");
            string input = Console.ReadLine();
            string[] inputList = input.Split(',');
            List<string> selectedPrograms = new List<string>();
            foreach (string inputItem in inputList)
            {
                if (int.TryParse(inputItem, out int programNumber))
                {
                    if (programs.ContainsKey(programNumber))
                    {
                        selectedPrograms.Add(programs[programNumber]);
                    }
                }
            }

            Console.WriteLine("Ви вибрали наступні програмні продукти:");
            foreach (string selectedProgram in selectedPrograms)
            {
                Console.WriteLine(selectedProgram);
            }

            Console.WriteLine();
            Console.WriteLine("Список програм згрупований за авторами:");
            foreach (KeyValuePair<string, List<string>> author in authors)
            {
                Console.WriteLine(author.Key + ":");
                foreach (string program in author.Value)
                {
                    Console.WriteLine("- " + program);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}