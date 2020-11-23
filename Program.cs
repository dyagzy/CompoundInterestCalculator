using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompundInterestsAssignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchCaseCompoundIntetrestCal();
        }

        static void SwitchCaseCompoundIntetrestCal()
        {
            Console.WriteLine("!!!******!!!!****!!!**** Welcome  To Doshen Transatlantic Investment Bank !!!******!!!!****!!!**** ");
            Console.WriteLine("!!!******!!!!****!!!**** Your Gateway to Financial Freedeom !!!******!!!!****!!!**** ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The following are assumptions were made applicable depending on the type of account type for this mini-Console Banking App" );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"VAT : 12.5% for Current Account holders only \nDollar Debit card cost 2000 for Dom account holders only");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press 1 :\n To select Banking with us or \nPress 2: \nFor general Inquiry");
            int optionSelection = int.Parse(Console.ReadLine());

            switch (optionSelection)
            {
                case 1:

                    Console.WriteLine("Please choose your type of account from the list below \n Savings Account : 1 \n Current Account : 2 \n Dollar Account : 3 \n");

                    string options = Console.ReadLine();
                    int accountType;
                    bool accounttype = int.TryParse(options, out accountType);

                    Console.WriteLine("Please enter your principal to be invested");
                    decimal principal = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the Time to be invested");
                    int time = int.Parse(Console.ReadLine());

                    //Variable declarations
                    const int numberOfTenure = 12;
                    decimal amountDue = 0.0m;
                    decimal amountPayAble = 0.0m;
                    const double rate = 0.05;
                    const int dollarDebiCard = 2000;
                    const decimal vat = 0.125m;

                    //Formula

                    double timeFactor = time * numberOfTenure;
                    double multiplier = 1 + (rate / numberOfTenure);
                    amountDue = principal * (decimal)Math.Pow(multiplier, timeFactor);

                   

                    //Compund Interest by Account type selected 
                    if (accounttype)
                    {
                        switch (accountType)
                        {
                            case 1:
                                 amountDue = principal * (decimal) Math.Pow(multiplier, timeFactor);
                                Console.WriteLine($"The value of your investment with a Principal of {principal}, compounded " +
                                    $"annually at { numberOfTenure} at a rate of {rate} and time t of {time} is : {amountDue}");
                                Console.ReadLine();
                                break;

                            case 2:
                                amountDue = principal * (decimal)Math.Pow(multiplier, timeFactor);
                                amountPayAble = vat * amountDue;
                                Console.WriteLine($"The value of your investment with a Principal of {principal}, compounded " +
                                    $"annually at {numberOfTenure} at a rate of {rate} and time t of {time} is : {amountPayAble}");
                                Console.ReadLine();

                                break;

                            case 3:
                                amountDue = principal * (decimal)Math.Pow(multiplier, timeFactor);
                                amountPayAble = (vat * amountDue) - dollarDebiCard;
                                Console.WriteLine($"The value of your investment with a Principal of {principal}, compounded " +
                                    $"annually at {numberOfTenure} at a rate of {rate} and time t of {time} is : {amountPayAble}");
                                Console.ReadLine();
                                break;

                            default:
                                Console.WriteLine("What type of account type do you own?");
                                Console.ReadLine();
                                break;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalide account type was selected");
                        Console.ReadLine();
                    }


                    break;

                case 2:
                    Console.WriteLine("Contact Customer desk for general inquiries on 08060335875");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalide selection press try again");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
