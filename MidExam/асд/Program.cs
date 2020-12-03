using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendList = Console.ReadLine()
                .Split(',')
                .ToList();

            string command = Console.ReadLine();

            while (command != "Report")
            {
                string[] cmdArgs = command.Split();
                string currCommand = cmdArgs[0];

                if (currCommand == "Blacklist")
                {
                    string name = cmdArgs[1];
                    
                    
                    if (friendList.Contains(name))
                    {
                        for (int i = 0; i < friendList.Count; i++)
                        {
                            if (friendList[i] == name)
                            {
                                Console.WriteLine($"{name} was blacklisted.");
                                friendList[i] = "Blacklisted";
                                
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                        
                    }

                }
                else if (currCommand == "Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (friendList[index] != "Blacklisted" && friendList[index] != "Lost")
                    {
                        Console.WriteLine($"{friendList[index]} was lost due to an error.");
                        friendList[index] = "Lost";
                    }

                }
                else if (currCommand == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];
                    if (index <= friendList.Count - 1)
                    {
                        Console.WriteLine($"{friendList[index]} changed his username to {newName}.");
                        friendList.Remove(friendList[index]);
                        friendList.Insert(index, newName);
                    }

                }
                command = Console.ReadLine();
            }
            int lostNamesCount = 0;
            for (int i = 0; i < friendList.Count; i++)
            {
                if (friendList[i] == "Lost")
                {
                    lostNamesCount++;
                }
            }
            int blacklistedNamesCount = 0;
            for (int i = 0; i < friendList.Count; i++)
            {
                if (friendList[i] == "Blacklisted")
                {
                    blacklistedNamesCount++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", friendList));
        }
    }
}
