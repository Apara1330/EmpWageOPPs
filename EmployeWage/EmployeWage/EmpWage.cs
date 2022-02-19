using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    public class EmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public static int empHrs = 0;
        public void Emp(string company, int EmpRatePerHr,int MaxWorkingHrs,int MaxWorkingDays)
        {
            int empWage;
            int days = 1;
            int empWorkingHrs = 0;
            int totalWage = 0;


            Random random = new Random();//to generate random number
            while (empWorkingHrs < MaxWorkingHrs && days <= MaxWorkingDays) 
            {
                int randomInput = random.Next(0, 3);
                GetWorkingHrs(randomInput); //calling method to get working hours
                empWage = EmpRatePerHr * empHrs;
               // Console.WriteLine("Employee wage for day {0} is {1}", days, empWage);
                totalWage = totalWage + empWage;
                empWorkingHrs = empHrs;
                
                if(empWorkingHrs > MaxWorkingHrs)
                {
                    empWorkingHrs = MaxWorkingHrs;
                }
                else
                {
                    days++;
                }

            }
            Console.WriteLine(" In {0} company Employee worked for {1}days out of {2}days and {3}hours out of {4}hours so Employe wage is:{5} ", company, days - 1, MaxWorkingDays, empWorkingHrs, MaxWorkingHrs, totalWage);

        }


        public static void GetWorkingHrs(int randomInput)//This method calculates emp hours
        {
            switch (randomInput)//switc case to check employee present or absent
            {
                case FULL_TIME:
                    empHrs = 8;
                    //Console.WriteLine("Employee is present Fulltime");
                    break;
                case PART_TIME:
                    empHrs = 4;
                   // Console.WriteLine("Employee is present Parttime");
                    break;
                default:
                    empHrs = 0;
                   // Console.WriteLine("Employee is Absent");
                    break;
            }
        }


    }
}
