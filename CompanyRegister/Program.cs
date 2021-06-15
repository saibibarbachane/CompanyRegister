using System;
using System.Collections.Generic;

namespace CompanyRegister
{
    class Program
    {
        static void Main(string[] args)
        {

            Workers workers = new Workers();
            List<Workers> people = new List<Workers>();
            bool check = true;
            while (check)
            {
                Console.WriteLine("Please insert a Name or q to quit:");
                //string input = Console.ReadLine(); 
                workers.Name = Console.ReadLine();
                if (workers.Name == "q")
                {
                    break;
                    
                }

                Console.WriteLine("Please insert a Salary:");
                try
                {
                    workers.Salary = double.Parse(Console.ReadLine());

                }
                catch (ArgumentException ex)
                {
                    workers.Salary = 0;
                   
                }
                people.Add(workers);

            }
            
            foreach (var item in people)
            {
                Console.WriteLine($"Worker Name: {item.Name} , Worker Salary: {item.Salary}");
            }



        }

    }
}
