namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            Random obj = new Random();
            int empCheck = obj.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present ");

            }
            else
            {
                Console.WriteLine("Employee is absent");

            }
        
     

        }
    }
}