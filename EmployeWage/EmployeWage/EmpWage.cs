using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    public class EmpWage
    {
        public static void Emp()
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            int empHrs = 0;
            int totalHrs = 0;
            int empWagePrHr = 20;
            int total_Wage = 0;
            int Max_Working_Days = 20;
            int days = 1;
            Random random = new Random();


            for (days = 1; days < Max_Working_Days; days++)//19 times
            {
                int RandomNumber = random.Next(0, 3);//random here used to check if employee is present or not
                if (RandomNumber == Full_Time)
                {
                    Console.WriteLine("Employee worked Full time");
                    empHrs = 8;
                }
                else if (RandomNumber == Part_Time)
                {
                    Console.WriteLine("Employee worked Part time");
                    empHrs = 4;
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                }
               
                totalHrs += empHrs; //Adding employee total hours 
                total_Wage = totalHrs * empWagePrHr;//calculating total wage
                Console.WriteLine("Employee Total wage is = "+total_Wage);
            }

        }
    }
}