using System;
using System.Collections.Generic;



namespace ExceptionsTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Worker> workersList = new List<Worker>()
            {
                new Worker("Ben",10),
                new Worker("Alfred",60),
                new Worker("Loda",28)
            };
           
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            if (NumbCheck(name))
            {
                throw new CustomException(name," is invalid worker's name");
            }

            if (age<18)
            {
                throw new CustomException("invalid worker's age");
            }
           
            workersList.Add(new Worker(name,age));

            Console.WriteLine(String.Join("\n",workersList));
          

        }
        
        static bool NumbCheck(string name4Check)
        {
            bool val = false;
            for (int i = 0; i < 10; i++)
            {
                if (name4Check.Contains(i.ToString()))
                {
                    val = true;
                    break;
                }
            }
            return val;
        }
    }
}