using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    public class EmpWage
    {
        public int empHrs;
        public int empTotalWage;
        public void Calculation()
        {
            int WagePerHrs = 20;
            Random random = new Random();

            int RandomNumber = random.Next(0, 2);//To check employee is present or not
            
            if (RandomNumber == 0)
            {
                Console.WriteLine("Employee is Present");
                int check = random.Next(0, 2);//To check employee is full time or not
                if (check == 1)
                {
                    Console.WriteLine("Employee is present for full time");
                    empHrs = 8;//for full time working hrs must be 8.
                }
                else if (check==1)
                {
                Console.WriteLine("Employe is present for part time");
                empHrs = 4;
                }

        }
        else
            {
                Console.WriteLine("Emplyee is Absent");
            }
        //calculating total emp wage
        empTotalWage = WagePerHrs* empHrs;
        //printing total emp wage
        Console.WriteLine("EmployeWage Total Wage is = "+empTotalWage);

        }
    }
}