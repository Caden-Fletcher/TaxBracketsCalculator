namespace TaxBracketsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalIncome = 0;

            Console.WriteLine("Please enter the total income you made in 2023: ");
            totalIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(totalIncome);
        }
    }
}