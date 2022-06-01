using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationUsingMethods
{
    internal class EmpWageComputation
    {
        public void UC_1_EmpAttendance()
        {
            int isPresent = 1;
            int randomCheck;
            Random random = new Random();
            randomCheck = random.Next(2);
            if (randomCheck == isPresent)
            {
                Console.WriteLine("The Employee is Present ");
            }
            else
            {
                Console.WriteLine("The Employee is Absent ");
            }
        }
    }
}
