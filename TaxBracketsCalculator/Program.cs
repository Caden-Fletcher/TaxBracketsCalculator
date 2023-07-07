namespace TaxBracketsCalculator
{
    internal class Program
    {
        static int Main(string[] args)
        {
            // 2023 Tax Brackets for Single Filer
            bool incomeExceeds11000 = false; // $0 to $11,000 = 10%
            bool incomeExceeds44725 = false; // $11,001 to $44,725 = 12%
            bool incomeExceeds95375 = false; // $44,726 to $95,375 = 22%
            bool incomeExceeds182100 = false; // $95,376 to $182,100 = 24%
            bool incomeExceeds231250 = false; // $182,101 to $231,250 = 32%
            bool incomeExceeds578125 = false; // $231,251 to $578,125 = 35%
                                              // $578,126 or more = 37%
            
            double temporaryConversion = 0;
            double totalIncome = 0;
            double totalTaxesPaid = 0;

            Console.WriteLine("This program will assume you are filing under Single Filer");
            Console.WriteLine("Please enter the total income you made in 2023: ");
            totalIncome = Convert.ToDouble(Console.ReadLine());

            // Set the booleans to true if the users income has exceeded that number
            if (totalIncome > 11000)
            {
                incomeExceeds11000 = true;
            }
            if (totalIncome > 44725)
            {
                incomeExceeds44725 = true;
            }
            if (totalIncome > 95375)
            {
                incomeExceeds95375 = true;
            }
            if (totalIncome > 182100)
            {
                incomeExceeds182100 = true;
            }
            if (totalIncome > 231250)
            {
                incomeExceeds231250 = true;
            }
            if (totalIncome > 578125)
            {
                incomeExceeds578125 = true;
            }

            // Calculate taxes for the 10% tax bracket, if the user has not made above $11,000 then the calculation will end after this
            if (incomeExceeds11000 == true)
            {
                temporaryConversion = 11000 * 0.1; // $0 to $11,000 = 10%
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;
            }
            if (incomeExceeds11000 == false)
            {
                temporaryConversion = totalIncome * 0.1;
                totalTaxesPaid = temporaryConversion;

                Console.WriteLine(totalTaxesPaid);
                return 0; // No further calculations are needed, end the program
            }

            // Calculate taxes for the 12% tax bracket, if the user has not made above $44,725 then the calculation will end after this
            if (incomeExceeds44725 == true)
            {
                temporaryConversion = 33725 * 0.12; // $11,001 to $44,725 = 12%
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;
            }
            if (incomeExceeds44725 == false)
            {
                temporaryConversion = (totalIncome - 11000) * 0.12; // Minus the amount from the previous brackets
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;

                Console.WriteLine(totalTaxesPaid);
                return 1; // No further calculations are needed, end the program
            }

            // Calculate taxes for the 22% tax bracket, if the user has not made above $95,375 then the calculation will end after this
            if (incomeExceeds95375 == true)
            {
                temporaryConversion = 50650 * 0.22; // $44,726 to $95,375 = 22%
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;
            }
            if (incomeExceeds95375 == false)
            {
                temporaryConversion = (totalIncome - 44725) * 0.22; // Minus the amount from the previous brackets
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;

                Console.WriteLine(totalTaxesPaid);
                return 2; // No further calculations are needed, end the program
            }

            // Calculate taxes for the 24% tax bracket, if the user has not made above $182,100 then the calculation will end after this
            if (incomeExceeds182100 == true)
            {
                temporaryConversion = 86725 * 0.24; // $95,376 to $182,100 = 24%
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;
            }
            if (incomeExceeds182100 == false)
            {
                temporaryConversion = (totalIncome - 95375) * 0.24; // Minus the amount from the previous brackets
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;

                Console.WriteLine(totalTaxesPaid);
                return 3; // No further calculations are needed, end the program
            }

            // Calculate taxes for the 32% tax bracket, if the user has not made above $231,250 then the calculation will end after this
            if (incomeExceeds231250 == true)
            {
                temporaryConversion = 49150 * 0.32; // $182,101 to $231,250 = 32%
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;
            }
            if (incomeExceeds231250 == false)
            {
                temporaryConversion = (totalIncome - 182100) * 0.32; // Minus the amount from the previous brackets
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;

                Console.WriteLine(totalTaxesPaid);
                return 4; // No further calculations are needed, end the program
            }

            // Calculate taxes for the 35% tax bracket, if the user has not made above $578,125 then the calculation will end after this
            if (incomeExceeds578125 == true)
            {
                temporaryConversion = 346875 * 0.35; // $231,251 to $578,125 = 35%
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;
            }
            if (incomeExceeds578125 == false)
            {
                temporaryConversion = (totalIncome - 231250) * 0.35; // Minus the amount from the previous brackets
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;

                Console.WriteLine(totalTaxesPaid);
                return 5; // No further calculations are needed, end the program
            }

            // Calculate taxes for the 37% tax bracket, if the user has made above $578,125 then this is the final calculation
            if (incomeExceeds578125 == true)
            {
                temporaryConversion = (totalIncome - 578125) * 0.37; // Minus the amount from the previous brackets
                totalTaxesPaid = totalTaxesPaid + temporaryConversion;

                Console.WriteLine(totalTaxesPaid);
                return 6; // No further calculations are needed, end the program
            }

            return 7; // Error code, you shouldn't be here!
        }
    }
}