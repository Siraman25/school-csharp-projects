using System;
using System.Collections;

namespace Uebung26_NamenArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList valueList = new ArrayList();
            while (true)
            {
                
                Console.Write("Please enter a value:");
                string value = "";
                value = Console.ReadLine();
                if (value.ToLower() == "quit" || value.ToLower() == "exit")
                {
                    foreach (var element in valueList)
                    {
                        Console.WriteLine(element);
                    } 
                    System.Environment.Exit(0);
                }
                else
                {
                    valueList.Add(value);
                }
            }
        }
    }
}