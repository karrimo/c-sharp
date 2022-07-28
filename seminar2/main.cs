using System;

public class Program
{
    public static void Main(string[] args)
    {
      
        void Task10()
        {
            int number = 157;
            if (number > 99 && number < 1000)
            {
                Console.WriteLine("Second digit of the number: " + (number / 10 % 10));
            }
            else
            {
                Console.WriteLine("Not a three-digit number");
            }
        }
        
        void Task13()
        {
            int number = 15;
            
            if(number < 100){
                Console.WriteLine("No third digit");
                return;
            }
            
            while (number > 999)
            {
               number/=10;
            }
            
            Console.WriteLine(number%10);
        }
        
        void Task15()
        {
            int number = 3;
            
            if(number == 6 || number == 7){
                Console.WriteLine(number + " -> Yes");
            }
            else
            {
                 Console.WriteLine(number + " -> No");
            }
        }
        
        // Task10();
        // Task13();
        Task15();
            
    }
}

