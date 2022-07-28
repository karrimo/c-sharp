using System;

public class Program
{
    public static void Main(string[] args)
    {
        void Task2()
        {
            int first = 2;
            int second = 2;
            
            if(first > second)
            {
                Console.WriteLine("first bigger");
            }
            else if (second > first)
            {
                Console.WriteLine("second bigger");
            }
            else 
            {
                Console.WriteLine("equal");
            }
            
        }
        
        void Task4()
        {
            int first = 6;
            int second = 5;
            int third = 3;
            int max = first;
            
            if(second > max)
            {
                max = second;
            }
            
            if(third > max)
            {
                max = third;
            }
            
            Console.WriteLine(max);
        }
        
        void Task6()
        {
            int number = 2;
            
            if(number % 2 == 0)
            {
                Console.WriteLine("Yes");
            }
            
            else
            {
                Console.WriteLine("No"); 
            }
        }
        
        void Task8()
        {
            int n = 10;
            int count = 1;
            
            while(count <= n)
            {
                if(count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            }
        }
        
        // Task2();
        // Task4();
        // Task6();
        Task8();
            
    }
}

