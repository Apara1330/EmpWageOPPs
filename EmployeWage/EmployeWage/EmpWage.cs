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
        public static void Emp()
        {
            int totalWage = 0;
            int empWage;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int days = 1;
            int empWorkingHrs = 0;


            Random random = new Random();
            while (days <= MAX_WORKING_DAYS && empWorkingHrs <= MAX_WORKING_HRS)//iterating days out of max working days and hours 
            {
                int randomInput = random.Next(0, 3);
                GetWorkingHrs(randomInput); //calling method to get working hours
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Employee wage for day {0} is {1}", days, empWage);
                totalWage = totalWage + empWage;
                empWorkingHrs = empWorkingHrs + empHrs;
                days++;

            }
            Console.WriteLine("Total wage for {0}days and hrs:{1} is:{2} ", MAX_WORKING_DAYS, empWorkingHrs, totalWage);
        }


        public static void GetWorkingHrs(int randomInput)//This method calculates emp hours
        {
            switch (randomInput)//switc case to check employee present or absent
            {
                case FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is present Fulltime");
                    break;
                case PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is present Parttime");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }


    }
}
