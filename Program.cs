using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int liftALifecycle = 0;
            int liftBLifecycle = 0;


            while (true)
            {
               

                Console.WriteLine("stage of elevator A (0-10)");
                int firstLift = Int32.Parse(Console.ReadLine());
                Console.WriteLine("stage of elevator B (0-10)");
                int secondLift = Int32.Parse(Console.ReadLine());

                Console.WriteLine("input your current stage(0-10)");
                int current = Int32.Parse(Console.ReadLine());


                int LiftA = current > firstLift ? LiftA = current - firstLift : LiftA = firstLift - current;
                int LiftB = current > secondLift ? LiftB = current - secondLift : LiftB = secondLift - current;

                if (LiftA < LiftB)
                {
                    liftALifecycle += LiftA;
                    Console.WriteLine("Elevator A");
                }
                else if (LiftA == LiftB)
                {
                    if (liftALifecycle > liftBLifecycle)
                    {
                        liftBLifecycle += LiftA;
                        Console.WriteLine("Elevator B");
                    }
                    else if (liftALifecycle < liftBLifecycle)
                    {
                        liftALifecycle += LiftA;
                        Console.WriteLine("Elevator A");
                    }
                    else
                    {
                        liftALifecycle += LiftA;
                        Console.WriteLine("Elevator A");
                    }
                }
                else
                {
                    liftBLifecycle += LiftB;
                    Console.WriteLine("Elevator B");
                }
                Console.WriteLine(liftALifecycle);
                Console.WriteLine(liftBLifecycle);

                Console.WriteLine();
            }
        }        
    }
}
