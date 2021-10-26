using System;


namespace AddingNumbersPerLetters
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // title
            Console.WriteLine("Letter to Number");
            Console.WriteLine();

            // initialization / declaration / arrays
            char[] stringToChar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[] charToInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
            string firstName, middleName, lastName;
            char askConfirm = ' ', anotherTry = ' ';

            // declaring methods to functions
            StringEntry();
            StringConfirmation();
            processMain();
           
            // start of methods

            // this is the data entry process method
            void StringEntry()
            {

                Console.Write("Enter FirstName: ");
                firstName = Console.ReadLine().ToUpper();
                Console.Write("Enter MiddleName: ");
                middleName = Console.ReadLine().ToUpper();
                Console.Write("Enter LastName: ");
                lastName = Console.ReadLine().ToUpper();
                Console.WriteLine();

            }

            void StringConfirmation()
            {

                Console.WriteLine($"Your name is {firstName} {middleName} {lastName}");
                Console.WriteLine();
                Console.Write("Confirmation, does the name Correct ? (y/n)... (x) for exit: ");
                askConfirm = char.Parse(Console.ReadLine());
                Console.WriteLine();

            }

            // Main Process Method
            void processMain()
            {

                if (askConfirm == 'y' || askConfirm == 'Y')
                {
                    // this the main process statement

                    // initialization from string to char Array
                    char[] firstnameCharArr = firstName.ToCharArray();
                    char[] middlenameCharArr = middleName.ToCharArray();
                    char[] lastnameCharArr = lastName.ToCharArray();

                    // initialization for statement
                    bool contains = false;
                    int firstnameToInt = 0, middlenameToInt = 0, lastnameToInt = 0;
                    int sumOfFirstName = 0, sumOfMiddleName = 0, sumOfLastName = 0;
                    int i = 0, j = 0, sumOfTotalLetters = 0;

                    // for statement to get number from the alphabet then sum
                    for (i = 0; i < firstName.Length; i++)
                    {

                        for (j = 0; j < stringToChar.Length; j++)
                        {
                            if (firstnameCharArr[i] == stringToChar[j])
                            {
                                contains = true;
                                firstnameToInt = charToInt[j];
                            }
                        }
                        sumOfFirstName += firstnameToInt;
                    }

                    for (i = 0; i < middleName.Length; i++)
                    {
                        for (j = 0; j < stringToChar.Length; j++)
                        {
                            if (middlenameCharArr[i] == stringToChar[j])
                            {
                                contains = true;
                                middlenameToInt = charToInt[j];
                            }

                        }
                        sumOfMiddleName += middlenameToInt;
                    }

                    for (i = 0; i < lastName.Length; i++)
                    {
                        for (j = 0; j < stringToChar.Length; j++)
                        {
                            if (lastnameCharArr[i] == stringToChar[j])
                            {
                                contains = true;
                                lastnameToInt = charToInt[j];
                            }

                        }
                        sumOfLastName += lastnameToInt;
                    }

                    sumOfTotalLetters = sumOfFirstName + sumOfMiddleName + sumOfLastName;

                    if (contains == true)
                    {

                        Console.WriteLine($"The Sum of Letters for {firstName} is {sumOfFirstName}");
                        Console.WriteLine($"The Sum of Letters for {middleName} is {sumOfMiddleName}");
                        Console.WriteLine($"The Sum of Letters for {lastName} is {sumOfLastName}");
                        Console.WriteLine($"The Total Sum is {sumOfTotalLetters}");
                        Console.WriteLine();

                        tryAgain();

                    }
                    else
                    {

                        Console.WriteLine("Not valid for Operation");
                    
                    }
                }
                else if (askConfirm == 'n' || askConfirm == 'N')
                {

                    Console.WriteLine("Please re-enter your name.");

                    StringEntry();
                    StringConfirmation();
                    processMain();
                
                }
                else if (askConfirm == 'x' || askConfirm == 'X')
                {

                    Console.WriteLine("Cancelled.");
                
                }
                else
                {

                    Console.WriteLine("Not Valid Selection.");
                
                }

                // Try Again Method
                void tryAgain()
                {
                    // confirmation statement to retry
                    Console.Write("Try again? (y/n): ");
                    anotherTry = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (anotherTry == 'y' || anotherTry == 'Y')
                    {

                        StringEntry();
                        StringConfirmation();
                        processMain();

                    }
                    else if (anotherTry == 'n' || anotherTry == 'N')
                    {

                        Console.WriteLine("Cancelled.");
                    
                    }
                    else
                    {

                        Console.WriteLine("Not Valid Selection.");
                    
                    }
                }

            }

        }
    }
}
