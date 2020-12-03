using System;

namespace Articles_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sample = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            Article article1 = new Article(sample[0], sample[1], sample[2]);
            for (int i = 0; i <n; i++)
            {
                string[] comand = Console.ReadLine().Split(": ");
                switch(comand[0].ToLower())
                {
                    case "edit":
                        article1.Edit(comand[1]);
                        break;
                    case "changeauthor":
                        article1.ChangeAuthor(comand[1]);
                        break;
                    case "rename":
                        article1.Rename(comand[1]);
                        break;
                }
            }
            Console.WriteLine(article1);
        }
    }
}
