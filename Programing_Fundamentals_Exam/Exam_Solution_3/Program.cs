using System;
using System.Collections.Generic;
using System.Linq;





namespace Exam_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, Chat> spisuk = new Dictionary<string, Chat>();
            string[] comands = Console.ReadLine().Split('=', StringSplitOptions.RemoveEmptyEntries);
            while (comands[0]!="Statistics")
            {
                switch (comands[0])
                {
                    case "Add":
                        if (spisuk.ContainsKey(comands[1]))
                        {
                            
                        }else
                        {
                            spisuk.Add(comands[1], new Chat(comands[1], int.Parse(comands[2]), int.Parse(comands[3])));
                        }
                        break;
                    case "Message":
                        if (spisuk.ContainsKey(comands[1])&&spisuk.ContainsKey(comands[2]))
                        {
                            spisuk[comands[1]].Message(1);
                            spisuk[comands[1]].Sent += 1;
                            spisuk[comands[2]].Message(1);
                            spisuk[comands[2]].Recived += 1;
                            if (capacity<=spisuk[comands[1]].Sum)
                            {
                                Console.WriteLine($"{comands[1]} reached the capacity!");
                                spisuk.Remove(comands[1]);
                            }
                            if (capacity<=spisuk[comands[2]].Sum)
                            {
                                Console.WriteLine($"{comands[2]} reached the capacity!");
                                spisuk.Remove(comands[2]);
                            }
                        }
                        break;
                    case "Empty":
                        if (comands[1]=="All")
                        {
                            spisuk.Clear();
                        }
                        spisuk.Remove(comands[1]);
                        break;
                    default:
                        break;
                }
                comands= Console.ReadLine().Split('=', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Users count: {spisuk.Count}");
            
            foreach (var item in spisuk.OrderByDescending(x=>x.Value.Recived).ThenBy(x=>x.Value.Name))
            {
                int sum = item.Value.Recived + item.Value.Sent;
                Console.WriteLine($"{item.Value.Name} - {sum}");
            }
        }
    }
}
