using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Elevator
{
    class UnitTests
    {

        #region comments

        //public static bool GetElevator_LiftABelowLiftBAbove_LiftBOptimal_ReturnsB()
        //{
        //    Program.SaveElevatorsLifespan(0, 0);

        //    string expected = "Elevator B";

        //    string actual = Program.GetElevator(1, 9, 8);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        //public static bool GetElevator_LiftABelowLiftBAbove_LiftAOptimal_ReturnsA()
        //{
        //    Program.SaveElevatorsLifespan(0, 0);

        //    string expected = "Elevator A";

        //    string actual = Program.GetElevator(1, 9, 2);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        //public static bool GetElevator_LiftBBelowLiftAAbove_LiftAOptimal_ReturnsB()
        //{
        //    Program.SaveElevatorsLifespan(0, 0);

        //    string expected = "Elevator B";

        //    string actual = Program.GetElevator(9, 1, 2);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        //public static bool GetElevator_LiftBBelowLiftAAbove_LiftBOptimal_ReturnsA()
        //{
        //    Program.SaveElevatorsLifespan(0, 0);

        //    string expected = "Elevator A";

        //    string actual = Program.GetElevator(9, 1, 8);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        //public static bool GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftBMorethanAAboveMe_LiftBOptimal_ReturnsA()
        //{
        //    Program.SaveElevatorsLifespan(0, 5); // lift B has been used and has lifecycle 5 floors, will call lift with less lifecycle (Lift A)

        //    string expected = "Elevator A";

        //    string actual = Program.GetElevator(9, 9, 5);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        //public static bool GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftAMorethanBAboveMe_LiftBOptimal_ReturnsB()
        //{
        //    Program.SaveElevatorsLifespan(5, 0); // lift A has been used and has lifecycle 5 floors, will call lift with less lifecycle (Lift B)

        //    string expected = "Elevator B";

        //    string actual = Program.GetElevator(9, 9, 5);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        //public static bool GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftBMorethanABelowMe_LiftBOptimal_ReturnsA()
        //{
        //    Program.SaveElevatorsLifespan(0, 5); // lift B has been used and has lifecycle 5 floors, will call lift with less lifecycle (Lift A)

        //    string expected = "Elevator A";

        //    string actual = Program.GetElevator(1, 1, 5);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        //public static bool GetElevator_LiftAAndLiftBInTheSameFloorAndLifecycleLiftAMorethanBBelowMe_LiftBOptimal_ReturnsB()
        //{
        //    Program.SaveElevatorsLifespan(5, 0); // lift A has been used and has lifecycle 5 floors, will call lift with less lifecycle (Lift B)

        //    string expected = "Elevator B";

        //    string actual = Program.GetElevator(1, 1, 5);

        //    if (actual != expected)
        //    {
        //        Console.WriteLine($"Failed {MethodBase.GetCurrentMethod().Name}: Expected: {expected}, actual: {actual}");

        //        return false;
        //    }
        //    return true;
        //}

        # endregion


        public static bool UnitTestMethod(int liftAStartPosition, int liftBStartPosition, string methodName, string excepted, int liftAPostion, int liftBPosition, int myPostion)
        {
            Program.SaveElevatorsLifespan(liftAStartPosition, liftBStartPosition);

            string actual = Program.GetElevator(liftAPostion, liftBPosition, myPostion);

            if (actual != excepted)
            {
                Console.WriteLine($"Failed {methodName}: Expected: {excepted}, actual: {actual}");

                return false;
            }
            return true;
        }
    }
}
