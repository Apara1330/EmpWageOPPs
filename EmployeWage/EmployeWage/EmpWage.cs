using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    public class EmpWage
    {
        public int empHrs=0;
        public int empTotalWage;
        public void Calculation()
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            int empWagePerHrs = 20;
            int Total_Wage = 0;
            Random random = new Random();

            int RandomNumber = random.Next(0, 3);
            switch (RandomNumber)
            {
                case Full_Time:
                    empHrs = 8;
                    Console.WriteLine("Employee worked for Full time");
                    break;
               
                case Part_Time:
                    empHrs = 4;
                    Console.WriteLine("Employee worked for Part time");
                    break;
               
                default:
                    Console.WriteLine("Employee is Absent");
                    break ;
             }
            
           
        //calculating total emp wage
        Total_Wage = empHrs * empWagePerHrs;
        //printing total emp wage
        Console.WriteLine("Employee Wage is = "+Total_Wage);

        }
    }
}