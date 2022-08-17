using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Task 27
        SumOfDigits(56784);
        SumOfDigits(7895);
        
        void SumOfDigits(int numb)
        {
            int sum = 0;
            Console.Write("The sum of digits of the number " + numb);
            while(numb > 0)
            {
                sum += numb%10;
                numb /= 10;
            }
            Console.WriteLine(" is " + sum);
        }
    }

}