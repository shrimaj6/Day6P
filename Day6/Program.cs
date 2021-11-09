using System;
using System.Diagnostics;

namespace Day6
{
    class mainProgram
    {
        static void Main(string[] args)
        {
        lable: Console.WriteLine("select the program : 1.fibonacci series\n2.Perfect number\n3.prime number\n4.reverse number\n5.CouponNumber\n6.SimulateStopWatch");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    fibonacciSeries obj1 = new fibonacciSeries();
                    obj1.logicPart();
                    break;
                case 2:
                    perfectNumber obj2 = new perfectNumber();
                    obj2.checkNum();
                    break;
                case 3:
                    primeNumber obj3 = new primeNumber();
                    obj3.opration();
                    break;

                case 4:
                    reversNumber obj4 = new reversNumber();
                    obj4.check();
                    break;

                case 5:
                    CouponNumber Obj5 = new CouponNumber();
                    Obj5.getCoupon();
                    break;

                case 6:
                    SimulateStopwatch Obj6 = new SimulateStopwatch();
                    Obj6.startStopWatch();
                    break;


                    Console.WriteLine("enter correct choice");
                    break;
            }

            Console.WriteLine("do you want to continue.....y/n");
            char key = char.Parse(Console.ReadLine());
            if (key == 'y')
            {
                goto lable;
            }
            else
            {
                Console.WriteLine("thank you ");
            }

        }
    }
}
