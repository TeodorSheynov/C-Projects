using System;
using System.Collections.Generic;

namespace Softuni_parking_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> userPlate = new Dictionary<string, string>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string comand = input[0];
                string user = input[1];
               
                switch (comand)
                {
                    case "register":
                        if (userPlate.ContainsKey(user))
                        { 
                            Console.WriteLine($"ERROR: already registered with plate number {userPlate[user]}");
                        }
                        else
                        {
                            userPlate.Add(user, input[2]);
                            Console.WriteLine($"{user} registered {input[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (!userPlate.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        else
                        {
                            userPlate.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var user in userPlate)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
