﻿using System;

namespace EmpWageComputationUsingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION IN CLASSES AND METHODS --------------");
            Console.WriteLine();

            EmpWageComputation computation = new EmpWageComputation();
            computation.UC_1_EmpAttendance();
        }
    }
}
