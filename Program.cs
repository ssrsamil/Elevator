using System;
using System.IO;

namespace Elevator
{
    class Program
    {
        static string path = @"C:\Elevator\Elevator.txt";

        static void Main(string[] args)
        {
            string folder = @"C:\Elevator";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            int failedTests = 0;

            //if (!UnitTests.GetElevator_LiftABelowLiftBAbove_LiftBOptimal_ReturnsB())
            //{
            //    failedTests++;
            //}
            //if (!UnitTests.GetElevator_LiftABelowLiftBAbove_LiftAOptimal_ReturnsA())
            //{
            //    failedTests++;
            //}
            //if (!UnitTests.GetElevator_LiftBBelowLiftAAbove_LiftAOptimal_ReturnsB())
            //{
            //    failedTests++;
            //}
            //if (!UnitTests.GetElevator_LiftBBelowLiftAAbove_LiftBOptimal_ReturnsA())
            //{
            //    failedTests++;
            //}
            //if (!UnitTests.GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftBMorethanAAboveMe_LiftBOptimal_ReturnsA())
            //{
            //    failedTests++;
            //}
            //if (!UnitTests.GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftAMorethanBAboveMe_LiftBOptimal_ReturnsB())
            //{
            //    failedTests++;
            //}
            //if (!UnitTests.GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftBMorethanABelowMe_LiftBOptimal_ReturnsA())
            //{
            //    failedTests++;
            //}
            //if (!UnitTests.GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftAMorethanBBelowMe_LiftBOptimal_ReturnsB())
            //{
            //    failedTests++;
            //}


            if (!UnitTests.UnitTestMethod(0, 0, "GetElevator_LiftABelowLiftBAbove_LiftBOptimal_ReturnsB", "Elevator B", 1, 9, 8))
            {
                failedTests++;
            }
            if (!UnitTests.UnitTestMethod(0, 0, "GetElevator_LiftABelowLiftBAbove_LiftAOptimal_ReturnsA", "Elevator A", 1, 9, 2))
            {
                failedTests++;
            }
            if (!UnitTests.UnitTestMethod(0, 0, "GetElevator_LiftBBelowLiftAAbove_LiftAOptimal_ReturnsB", "Elevator B", 9, 1, 2))
            {
                failedTests++;
            }
            if (!UnitTests.UnitTestMethod(0, 0, "GetElevator_LiftBBelowLiftAAbove_LiftBOptimal_ReturnsA", "Elevator A", 9, 1, 8))
            {
                failedTests++;
            }
            if (!UnitTests.UnitTestMethod(0, 5, "GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftBMorethanAAboveMe_LiftBOptimal_ReturnsA", "Elevator A", 9, 9, 5))
            {
                failedTests++;
            }
            if (!UnitTests.UnitTestMethod(5, 0, "GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftAMorethanBAboveMe_LiftBOptimal_ReturnsB", "Elevator B", 9, 9, 5))
            {
                failedTests++;
            }
            if (!UnitTests.UnitTestMethod(0, 5, "GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftBMorethanABelowMe_LiftBOptimal_ReturnsA", "Elevator A", 1, 1, 5))
            {
                failedTests++;
            }
            if (!UnitTests.UnitTestMethod(5, 0, "GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftAMorethanBBelowMe_LiftBOptimal_ReturnsB", "Elevator B", 1, 1, 5))
            {
                failedTests++;
            }
            

            if (failedTests == 0)
            {
                Console.WriteLine("Test completed succesfully!!");
            }

            //while (true)
            //{
            //    Console.WriteLine("stage of elevator A (0-10)");
            //    int firstLift = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("stage of elevator B (0-10)");
            //    int secondLift = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine("input your current stage(0-10)");
            //    int current = Int32.Parse(Console.ReadLine());

            //    string s = GetElevator(firstLift, secondLift, current);
            //    Console.WriteLine(s);
            //}
            Console.ReadKey();

        }

        public static void SaveElevatorsLifespan(int liftA, int liftB)
        {
            string[] arr = { liftA.ToString(), liftB.ToString() };

            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(arr[0]);
                sw.WriteLine(arr[1]);
            }
        }

        public static string[] ReadLifespan()
        {
            if (!File.Exists(path))
            {
                return new string[] { "0", "0" };
            }

            string[] lifespan = File.ReadAllLines(path);

            return lifespan;
        }

        public static string GetElevator(int firstLift, int secondLift, int current)
        {
            string[] arr = ReadLifespan();

            int liftALifecycle = Convert.ToInt32(arr[0]);
            int liftBLifecycle = Convert.ToInt32(arr[1]);

            int LiftA = current > firstLift ? LiftA = current - firstLift : LiftA = (firstLift - current) * 2;
            int LiftB = current > secondLift ? LiftB = current - secondLift : LiftB = (secondLift - current) * 2;

            if (LiftA < LiftB)
            {
                liftALifecycle += LiftA;
                SaveElevatorsLifespan(liftALifecycle, liftBLifecycle);
                return "Elevator A";
            }
            else if (LiftA == LiftB)
            {
                if (liftALifecycle > liftBLifecycle)
                {
                    liftBLifecycle += LiftA;
                    SaveElevatorsLifespan(liftALifecycle, liftBLifecycle);
                    return "Elevator B";
                }
                else if (liftALifecycle < liftBLifecycle)
                {
                    liftALifecycle += LiftA;
                    SaveElevatorsLifespan(liftALifecycle, liftBLifecycle);
                    return "Elevator A";
                }
                else
                {
                    liftALifecycle += LiftA;
                    SaveElevatorsLifespan(liftALifecycle, liftBLifecycle);
                    return "Elevator A";
                }
            }
            else
            {
                liftBLifecycle += LiftB;
                SaveElevatorsLifespan(liftALifecycle, liftBLifecycle);
                return "Elevator B";
            }
        } 
    }
}

