namespace EmployeeWageProblem
{
    internal class Program
    {
        
        
          public const  int Is_Part_Time = 1;
          public const  int Is_Full_Time = 2;   // Constants
           public const int Emp_Rate_Per_Hour = 100;

            static void Main(string[] args)
            {

                int empHrs = 0;   //Variables
                int empwage= 0;
                Random random= new Random();
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
            Console.WriteLine("Emp Wage : " + empwage);

     

        }
    }
}