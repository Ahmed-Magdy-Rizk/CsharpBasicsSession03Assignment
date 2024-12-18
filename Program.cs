using System.Diagnostics.Metrics;
using System;
using System.Threading.Channels;

namespace Session03Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             1- Write a program that takes a number from the user then print yes 
                if that number can be divided by 3 and 4 otherwise print no.
             */

            /*// Prompt user to enter a number
            Console.Write("Please type a number: ");

            // Create a var and get user input as a string and try to convert it to an int and store in the number var
            int.TryParse(Console.ReadLine(), out int number);

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }*/
            #endregion
            #region Q2
            /*
             2- Write a program that allows the user to insert an integer then print negative 
                if it is negative number otherwise print positive.
             */

            // Prompt user to enter an intger
            /*Console.Write("Please type a number: ");

            // Create a var and get user input as a string and try to convert it to an int and store in the number var
            int.TryParse(Console.ReadLine(), out int number);

            // Check wether the number potitive or negative.
            if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is postive");
            }
            */
            #endregion
            #region Q3
            /*
             3- Write a program that takes 3 integers from the user then prints the max element and the min element.
             */

            // Prompt user to enter 3 intger
            /*Console.Write("Please enter your first number: ");
            int.TryParse(Console.ReadLine(), out int number1);

            Console.Write("Please enter your second number: ");
            int.TryParse(Console.ReadLine(), out int number2);

            Console.Write("Please enter your third number: ");
            int.TryParse(Console.ReadLine(), out int number3);

            // we assume the max and min number is number1
            int max = number1;
            int min = number1;

            // frist get the max number
            if (number2 > max)
            {
                max = number2;
            }
            if (number3 > max)
            {
                max = number3;
            }

            // we get the min number
            if (number2 < min)
            {
                min = number2;
            }
            if (number3 < min)
            {
                min = number3;
            }

            Console.WriteLine($"max element is: {max}");
            Console.WriteLine($"min element is: {min}");*/
            #endregion
            #region Q4
            /*
             4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
             */

            //Prompt user to enter an intger
            /*Console.Write("Please enter your number: ");
            int.TryParse(Console.ReadLine(), out int number);

            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }*/
            #endregion
            #region Q5
            /*
             5- Write a program that takes character from the user then if it is a vowel chars
                (a,e,I,o,u) then print (vowel) otherwise print (consonant).
             */

            // Prompt user to enter a char
            /*Console.Write("Plase enter a char: ");
            char.TryParse(Console.ReadLine(), out char UserChar);

            // We convert the UserChar to lower case to make the comparison for lower case only
            char LowercaseChar = char.ToLower(UserChar);

            // Check if the character is a vowel
            if (LowercaseChar == 'a' || LowercaseChar == 'e' || LowercaseChar == 'i' || LowercaseChar == 'o' || LowercaseChar == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }*/
            #endregion
            #region Q7
            /*
             7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
             */
            // Prompt user to enter a number
            /*Console.Write("Please type a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(number * i);
                //Console.Write(" ");
            }*/
            #endregion
            #region Q8
            /*
             8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
             */

            // Prompt user to enter a number
            /*Console.Write("Please type a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
            #endregion
            #region Q9
            /*
             9- Write a program that takes two integers then prints the power.
             */
            //Prompt user to enter 2 number
            /*Console.WriteLine("Please type two number: ");
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);

            int answer = number1;
            for (int i = 1; i < number2; i++) 
            {
                answer *= number1;
            }
            Console.WriteLine(answer);*/
            #endregion
            #region Q10
            /*
             10- Write a program to enter marks of five subjects and calculate total, average and percentage.
             */
            // Promput user to input 5 marks
            /*Console.WriteLine("Please enter 5 marks: ");
            int.TryParse(Console.ReadLine(), out int mark1);
            int.TryParse(Console.ReadLine(), out int mark2);
            int.TryParse(Console.ReadLine(), out int mark3);
            int.TryParse(Console.ReadLine(), out int mark4);
            int.TryParse(Console.ReadLine(), out int mark5);

            // calculate total marks
            int TotalMarks = mark1 + mark2 + mark3 + mark4 + mark5;

            //calculate avg marks
            float Avg = TotalMarks / 5;

            // calculate percentage
            float Percentage = ((float)TotalMarks / 500) * 100;

            Console.WriteLine($"Total marks = {TotalMarks}");
            Console.WriteLine($"Average Marks  = {Avg}");
            Console.WriteLine($"Percentage  = {Percentage}%");*/
            #endregion
            #region Q11
            /*
             11- Write a program to input the month number and print the number of days in that month.
             */

            // Prompt user to enter a month number
            /*Console.Write("Please enter a month number: ");
            int.TryParse(Console.ReadLine(), out int MonthNumber);

            int days = 0;
            switch (MonthNumber)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    days = 31; 
                    break;
                case 4: case 6: case 9: case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28; 
                    break;
                default: 
                    Console.WriteLine("Please enter a valid month number");
                    break;
            }
            Console.WriteLine($"Days in Month: {days}");*/
            #endregion
            #region Q12
            /*
             12- Write a program to create a Simple Calculator.
             */
            //Prompt user to enter the first number
            /*Console.Write("Please enter your first number: ");
            int.TryParse(Console.ReadLine(), out int FirstNumber);
            
            //Prompt user to enter the second number
            Console.Write("Please enter your second number: ");
            int.TryParse(Console.ReadLine(), out int SecondNumber);

            // Prompt user to choose an operation
            Console.Write("Please an operation (+ - (-) - * - /): ");
            char.TryParse(Console.ReadLine(), out char OpChar);

            float Result = 0;
            bool ValidOp = true;

            switch (OpChar)
            {
                case '+':
                    Result = FirstNumber + SecondNumber;
                    break;
                case '-':
                    Result = FirstNumber - SecondNumber;
                    break;
                case '*':
                    Result = FirstNumber * SecondNumber;
                    break;
                case '/':
                    if (SecondNumber == 0)
                    {
                        Console.WriteLine("Can't divide by zero");
                        ValidOp = false;
                        break;
                    }
                    Result = FirstNumber / SecondNumber;
                    break;
                default:
                    Console.WriteLine("Invalid Operaton");
                    ValidOp = false;
                    break;
            }
            if (ValidOp == true)
            {
                Console.WriteLine($"Result = {Result}");
            }*/
            #endregion
            #region Q13
            /*
             13- Write a program to allow the user to enter a string and print the REVERSE of it.
             */

            // Prompt the user to enter a string
            /*Console.Write("Please enter a string: ");
            string UserInput = Console.ReadLine();

            string Result = "";
            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Result += UserInput[i];
            }

            Console.WriteLine($"Result: {Result}");*/

            #endregion
            #region Q14
            /*
             14- Write a program to allow the user to enter int and print the REVERSED of it.
             */
            // Prompt the user to enter a int
            /*Console.Write("Please enter a number: ");
            string UserInput = Console.ReadLine();

            string Result = "";
            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Result += UserInput[i];
            }

            int.TryParse(Result, out int NumberResult);

            Console.WriteLine($"Result: {NumberResult}");*/
            #endregion
            #region Q16
            /*
             16- . Write a program in C# Sharp to convert a decimal number into binary without using an array
             */
            // Prompt user to enter a decimal number
            /*Console.Write("Plase enter a decimal number: ");
            int.TryParse(Console.ReadLine(), out int Decimal);

            string ReveredResult = "";

            while (Decimal > 0)
            {
                if (Decimal % 2 == 1)
                {

                    ReveredResult += "1";
                }
                else
                {
                    ReveredResult += "0";
                }
                Decimal = Decimal / 2;
            }

            // Reverse the string to get the actual value
            string Result = "";
            for (int i = ReveredResult.Length - 1; i >= 0; i--)
            {
                Result += ReveredResult[i];
            }

            Console.WriteLine($"Result: {Result}");*/
            #endregion
            #region Q17
            /*
             17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
                and determines whether these points lie on a single straight line.
             */
            // Prompt user to input three points coordinates
            /*Console.Write("x1:");
            float.TryParse(Console.ReadLine(), out float x1);
            Console.Write("y1:");
            float.TryParse(Console.ReadLine(), out float y1);

            Console.Write("x2:");
            float.TryParse(Console.ReadLine(), out float x2);
            Console.Write("y2:");
            float.TryParse(Console.ReadLine(), out float y2);

            Console.Write("x3:");
            float.TryParse(Console.ReadLine(), out float x3);
            Console.Write("y3:");
            float.TryParse(Console.ReadLine(), out float y3);

            // we will apply the stright line equation between the first two points as  y = m * x + b 

            // frist we get the m (slope) from the first two points using the formula (y2 - y1) / (x2 - x1)
            float m = (y2 - y1) / (x2 - x1);

            // we get the value of b (y axis intercept) using the first point coordinates
            float b = y1 - m * x1;

            // now we use the formula to test wether the third point is on the same line

            // first we get the value of m * x + b and combare it to the left side as y3
            float RightSideOfEqueation = m * x3 + b;

            if (y3 == RightSideOfEqueation)
            {
                Console.WriteLine("The three points are on the same line");
            }
            else
            {
                Console.WriteLine("The three points are NOT on the same line");
            }*/
            #endregion
            #region Q18
            /*
             18- A worker's efficiency level is determined as follows: 
            - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
            - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
             */
            // Prompt the user to enter the time taken to complete the task
            /*Console.Write("Enter the time taken to complete the task : ");
            int.TryParse(Console.ReadLine(), out int TimeTaken);

            // Calculate the efficiency level using the time taken
            if (TimeTaken >= 2 && TimeTaken < 3)
            {
                Console.WriteLine("The worker is highly efficient.");
            }
            else if (TimeTaken >= 3 && TimeTaken < 4)
            {
                Console.WriteLine("The worker needs to increase their speed.");
            }
            else if (TimeTaken >= 4 && TimeTaken < 5)
            {
                Console.WriteLine("The worker needs training to enhance their speed.");
            }
            else if (TimeTaken >= 5)
            {
                Console.WriteLine("The worker is required to leave the company.");
            }
            else
            {
                Console.WriteLine("Invalid value. Please enter a time >=  2 hours.");
            }*/

            #endregion

        }
    }
}

