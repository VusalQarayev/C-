using System.Text;

namespace Tasks2
{
    internal class Program
    {
         static void Main(string[] args)
        {
            /* Task 1
            static int Factorial(int n)
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            int n = int.Parse(Console.ReadLine());
            int fact = Factorial(n);
            Console.WriteLine($"Factorial of {n} is {fact}");*/


            // Task 2
            /*
            double num1, num2, result;
            char op;

            Console.Write("Ilk ededi daxil edin: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Operator daxil edin (+, -, *, /): ");
            op = char.Parse(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }

            Console.ReadLine(); */


            // Task 3


            /*
                Console.WriteLine("------------- Temperature Converter -------------");
                Console.Write("Enter temperature: ");
                float input = float.Parse(Console.ReadLine());
                string option;
                float output;

                do
                {
                    Console.WriteLine("Convert From: ");
                    Console.WriteLine("A) Celcius To Fahrenheit. ");
                    Console.WriteLine("B) Fahrenheit To Celcius. ");
                    option = Console.ReadLine().ToLower();
                } while (option != "a" && option != "b");

                if (option == "a")
                {
                    output = (input * 9 / 5) + 32;
                }
                else
                {
                    output = (input - 32) * 5 / 9;
                };

                Console.WriteLine(output);
            */


            // Task 4
            /*
            static bool IsPalindrome()
            {
                Console.WriteLine("------------- isPalindrome -------------");
                Console.Write("Enter text: ");
                string text = Console.ReadLine().Trim();
                string textReversed = "";

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    textReversed += text[i];
                };

                return textReversed == text ? true : false;
            }
            */

            //Task 5
            /*
            static bool IsPerfect()
            {
                Console.WriteLine("------------- isPerfect -------------");
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int sum = 0;

                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                };

                return sum == num ? true : false;
            }
            */

            //Task 6
            /*
            static bool IsSimple()
            {
                Console.WriteLine("------------- isSimple -------------");
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                bool output = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        output = false;
                    };
                };

                return output;
            }
            */

            // Task 7
            //Console.WriteLine("eded daxil edin");
            //int a = int.Parse(Console.ReadLine()); 
            //for (int i = 1;i <=a; i++)
            //{
            //    for (int j = 0; j <i; j++) 
            //    {
            //        Console.Write("*");
            //        }
            //    Console.WriteLine();
            //}




            /*
            static void StarPrinter()
            {
                Console.WriteLine("------------- StarPrinter -------------");
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());
                int numOfStars = 1;
                int indexOfStart = rows - 1;

                for (int row = 0; row < rows; row++)
                {
                    string stars = "";

                    for (int col = 0; col < (rows * 2) - 1; col++)
                    {
                        if (col >= indexOfStart && col < indexOfStart + numOfStars)
                        {
                            stars += "*";
                        }
                        else
                        {
                            stars += "-";
                        }
                    };

                    numOfStars += 2;
                    indexOfStart -= 1;

                    Console.WriteLine(stars);
                }
            }
            */
            //Task 9

            /*

            Console.WriteLine("^------------- Fibonacci -------------^");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            string output = "";
            int memorized = 0;
            int current = 1;

            for (int i = 1; i <= num; i++)
            {
                current += memorized;
                memorized = current - memorized;

                if (current + memorized <= num)
                {
                    output += current + ", ";
                }
                else
                {
                    output += current + ".";
                    break;
                }
            };

            Console.WriteLine(output);
            */

            // Task 8

            //Console.WriteLine("eded daxxil edin");
            //int a = int.Parse(Console.ReadLine());
            //int teklik;
            //while (a > 0)
            //{
            //    teklik = a % 10;
            //    Console.WriteLine(teklik);
            //    a = a / 10;
            //}

            // Task 9

            Console.WriteLine("eded daxxil edin");
            int a = int.Parse(Console.ReadLine());
            int ilk = 0, ikinci = 1, novbeti;
            Console.Write(ilk + " ");
            Console.Write(ikinci + " ");

            for (int i = 2; i < a; i++) { 
             
                novbeti =ilk + ikinci;
                ilk = ikinci;
                ikinci=novbeti;
                Console.Write(novbeti + " ");

                
            
            }







        }

    }
}
