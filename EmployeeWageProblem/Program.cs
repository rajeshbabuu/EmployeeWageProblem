namespace EmployeeWageProblem
{
    internal class Program
    {
        
        
          public const  int Is_Part_Time = 1;
          public const  int Is_Full_Time = 2;   // Constants
          public const int Emp_Rate_Per_Hour = 100;
          public const int Num_Of_Working_Days = 20;

            static void Main(string[] args)
            {

                int empHrs = 0;   //Variables
                int empwage= 0;
            int totalEmpWage = 0;
            for (int day = 0; day < Num_Of_Working_Days; day++)
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


                empwage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage += empCheck;
                Console.WriteLine("Emp Wage : " + empwage);
            }
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
                Console.ReadLine();

     

        }
    }
}