using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    public class CouponNumber
    {
        public void getCoupon()
        {
            Console.WriteLine("Enter Number : ");
            int n = int.Parse(Console.ReadLine());
            Random ran = new Random();
            int check = ran.Next(1, 9);
            int count = 0;
            Console.WriteLine("Coupon Number is " + n);
            while (n > 0)
            {
                if (check == n)
                {
                    Console.WriteLine("Number is present ");
                    break;
                }
                count++;
                Console.WriteLine("count :" + count);
                n = n - 1;
            }
            Console.WriteLine("Number is present " + count);
        }
    }
}