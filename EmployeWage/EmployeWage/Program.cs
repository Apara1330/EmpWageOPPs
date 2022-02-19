using System;

namespace EmployeWage
{
    class Program
    {
        private void Main(string[] args)
        {
            // EmpWage.Calculation();
            EmpWage empWage = new EmpWage();
            empWage.Emp("Vaseline", 20, 40, 100);
            empWage.Emp("Boroline", 19, 50, 110);

            // EmpWage.Emp();
            Console.ReadLine(); 

        }
    }
}


