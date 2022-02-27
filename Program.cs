using System;
namespace Hey
{
    public class Hi
    {
        public static void Main(string[]args)
        {
            int num, rem, temp, sum = 0;
            Console.WriteLine("Enter your number");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if(temp==sum)
                {
                Console.WriteLine("Given number is an Armstrong Number");
                }
            else
            {
                Console.WriteLine("Given number is  not an Armstrong Number");
            }

        }
    }
}