namespace EmployeeWageProblem
{
    internal class Program
    {
        
        
          public const  int Is_Part_Time = 1;
          public const  int Is_Full_Time = 2;   // Constants
          public const int Emp_Rate_Per_Hour = 100;
          public const int Num_Of_Working_Days = 20;
        public const int Max_Hrs_In_Month = 100;

            static void Main(string[] args)
            {

                int empHrs = 0;   //Variables
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;
           while (totalEmpHrs <Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {


                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }


                
                totalEmpHrs += empCheck;
                Console.WriteLine("totalWorkingDays "+ "Employee Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
                Console.ReadLine();

     

        }
    }
}