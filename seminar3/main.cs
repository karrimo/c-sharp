using System;

public class Program
{
    public static void Main(string[] args)
    {
      
        void Task23()
        {
            int n = 10;
            int count = 1;
            
            Console.Write(n + " -> ");
             
            while(count <= n)
            {
                Console.Write(Math.Pow(count,3) + ", ");
                count++;
            }
        }
        
        Task23();
            
    }
}