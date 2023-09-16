namespace Try_and_Cacth_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 0;


            // If the code in "try" works everything is fine but if did not console executes codes in cacth if exception in paranthesis is encountered
            try
            {
                int result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");
                Console.Read();
            }



        }
    }
}