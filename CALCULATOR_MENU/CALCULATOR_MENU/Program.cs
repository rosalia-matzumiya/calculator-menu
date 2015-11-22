using System;

namespace Calculator_Menu
{
    class Program
    {
        const string FIRST_OPTION  = "1";
        const string SECOND_OPTION = "2";
        const string THIRD_OPTION  = "3";
        const string FOURTH_OPTION = "4";
        const string FIFTH_OPTION  = "5";
        const float FAIL           = -999999.9f;

        static string userOption;
        static float a = 0;
        static float b = 0;

        public static void Main(string[] args)
        {

            DisplayMenu();
            userOption = Console.ReadLine();
            DoOperation();
            VerifyUserInput(userOption);
            userOption = Console.ReadLine();
        }

        //Displays the actual menu.
        public static void DisplayMenu()
        {
            Console.WriteLine("** CALCULATOR MENU **");
            Console.WriteLine("1) Add two numbers.");
            Console.WriteLine("2) Subtract one number from another.");
            Console.WriteLine("3) Multiply two numbers.");
            Console.WriteLine("4) Divide one number by another.");
            Console.WriteLine("5) Calculate the remainder from dividing one number by another.");
            Console.Write("Please make your selection: ");
        }//end method



        //Tests to ensure inputs are floating numbers.
        static float VerifyUserInput(string userOption)
        {
            float testFloat;

            try
            {
                if (float.TryParse((userOption), out testFloat))
                {
                    return testFloat;
                }
            }
            catch
            {
                float userInput = 0;
                if (userInput == FAIL)
                {
                    //If there is an invalid input, catch it and print an error.
                    InvalidInput();
                    return FAIL;
                }
            }
            return 0;
        }//end method

        //This method performs the operation based on user input.
        static void DoOperation()
        {
            switch (userOption)
            {
                case FIRST_OPTION:          //Addition
                    {
                        Add();
                        break;
                    }
                case SECOND_OPTION:         //Subtraction
                    {

                        Subtract();
                        break;
                    }
                case THIRD_OPTION:          //Product
                    {
                        Multiply();
                        break;
                    }
                case FOURTH_OPTION:         //Division
                    {
                        Divide();
                        break;
                    }
                case FIFTH_OPTION:          //Modulus
                    {
                        Modulo();
                        break;
                    }

                default:
                    {
                        InvalidInput();
                        break;
                    }
            }
            userOption = Console.ReadLine();
        }//end method



        //Gets the A operand based on user input.
        public static float GetOperandA()
        {
            float operandA = VerifyUserInput(userOption);

            try
            {
                Console.Write("Please enter OperandA: ");
                operandA = float.Parse(Console.ReadLine());
                return operandA;
            }
            catch
            {
                //If there is an invalid input, catch it and return FAIL.
                InvalidInput();
                return FAIL;
            }
        }//end method

        //Gets the B operand based on user input.
        private static float GetOperandB()
        {
            float operandB = VerifyUserInput(userOption);

            try
            {
                Console.Write("Please enter OperandB: ");
                operandB = float.Parse(Console.ReadLine());
                return operandB;

            }
            catch
            {
                //If there is an invalid input, catch it and return FAIL.
                InvalidInput();
                userOption = Console.ReadLine();
                return FAIL;


            }
        }//end method

        //Prints the successful operation statement and 
        //tells the user to press enter to stop the program.
        public static void SuccessfulOperation()
        {
            Console.WriteLine("The operation has successfully completed.");
            Console.WriteLine("Please press 'Enter' to stop the program.");

            userOption = Console.ReadLine();
            System.Environment.Exit(0);
        }//end method

        //Prints an error message for invalid input. Tells the user to restart the program.
        public static void InvalidInput() 
        {
            Console.WriteLine("Invalid entry. Please restart the application.");
            userOption = Console.ReadLine();
            System.Environment.Exit(0);

        }

        public static void Add()
        {
            float sum = 0;

            Console.WriteLine("Where Sum = OperandA + OperandB: ");

            a = GetOperandA();
            b = GetOperandB();

            sum = a + b;
            Console.WriteLine("Sum = " + sum);
            SuccessfulOperation();
            userOption = Console.ReadLine();

        }//end method

        public static void Subtract()
        {
            float difference = 0;

            Console.WriteLine("Where Difference = OperandA - OperandB: ");
            a = GetOperandA();
            b = GetOperandB();

            difference = a - b;
            Console.WriteLine("Difference = " + difference);
            SuccessfulOperation();

            userOption = Console.ReadLine();
        }//end method

        public static void Multiply()
        {
            float product = 0;

            Console.WriteLine("Where Product = OperandA * OperandB: ");

            a = GetOperandA();
            b = GetOperandB();

            product = a * b;
            Console.WriteLine("Product = " + product);
            SuccessfulOperation();

        }//end method

        public static void Divide()
        {
            float quotient = 0;


            try
            {
                Console.WriteLine("Where Quotient = OperandA / OperandB: ");

                a = GetOperandA();
                b = GetOperandB();

                quotient = a / b;
                Console.WriteLine("Quotient = " + quotient);
                SuccessfulOperation();
            }
            catch
            {
                Console.Write(quotient);
                InvalidInput();
            }
        }//end method

        public static void Modulo()
        {
            float remainder = 0;

            Console.WriteLine("Where Modulus = OperandA % OperandB: ");

            a = GetOperandA();
            b = GetOperandB();

            remainder = a % b;
            Console.WriteLine("Modulus = " + remainder);
            SuccessfulOperation();

        }//end method

    }//end class
}