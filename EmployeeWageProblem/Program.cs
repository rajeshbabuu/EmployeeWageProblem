namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Is_Part_Time = 1;
            int Is_Full_Time = 2;   // Constants
            int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;   //Variables
            int empwage= 0;
            Random random= new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Part_Time)
            {
                empHrs = 4;
            }
            else if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empwage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage : " + empwage);

     

        }
    }
}