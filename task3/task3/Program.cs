using System.Diagnostics.Tracing;
using System.Text;

namespace task3
{
    internal class Program
    {
       public static void Main(string[] args)
        {


            Console.WriteLine("Task 1");
            int result = Cemi(5, 7);
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Task 2");
            Console.WriteLine(Tam("42"));     
            Console.WriteLine(Tam("-123"));   
            Console.WriteLine(Tam("3.14"));
            Console.WriteLine();

            Console.WriteLine("Task 3");
            Console.WriteLine(Cut_Tek("42"));
            Console.WriteLine(Cut_Tek("-123"));
            Console.WriteLine(Cut_Tek("3.14"));
            Console.WriteLine();

            Console.WriteLine("Task 4");
            Console.WriteLine(MenfiMusbet("42"));     
            Console.WriteLine(MenfiMusbet("-123"));   
            Console.WriteLine(MenfiMusbet("0"));
            Console.WriteLine(MenfiMusbet("4,56"));
            Console.WriteLine();

            Console.WriteLine("Task 5");
            Console.WriteLine(Ters(321));
            Console.WriteLine();

            Console.WriteLine("Task 6");
            Console.WriteLine(Hundred(125));
            Console.WriteLine();

            Console.WriteLine("Task 7,8");
            Console.WriteLine(SozTers("random text"));
            Console.WriteLine();

            Console.WriteLine("Task 9");
            Console.WriteLine(LongWord("salam men burdayam"));
            Console.WriteLine();

            Console.WriteLine("Task 10");
            Console.WriteLine(Capitalize("baki"));
            Console.WriteLine();

            Console.WriteLine("Task 11");
            Console.WriteLine(CapitalizeWords(" men bu gun Bakiya geldim"));
            Console.WriteLine();

            Console.WriteLine("Task 12");
            Console.WriteLine(SwapCase(" asSD dasDS asdDSDSD ASASs"));
            Console.WriteLine();
            
            Console.WriteLine("Task 13");
            Console.WriteLine(RemoveSait("SalasLAr"));
            Console.WriteLine();

            Console.WriteLine("Task 14");
            Console.WriteLine(ReduceSpaces(" baki     gozel      seherdir"));
            Console.WriteLine();

            Console.WriteLine("Task 15");
            Console.WriteLine(Limit(7));
            Console.WriteLine();


            Console.WriteLine("Task 16");
            Lim();
            Console.WriteLine();


            Console.WriteLine("Task 17");
            Console.WriteLine(Dein(5));
            Console.WriteLine();


            Console.WriteLine("Task 18");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(Password(d));
            Console.WriteLine();


            Console.WriteLine("Task 19");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine(Task(g));


            Console.WriteLine("Task 20");


        }

        // Task 1
        public static int Cemi(int a, int b)
        {

            int c = a + b;
            return c;
        }
        // Task 2
        public static bool Tam(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        // Task 3

        public static string Cut_Tek(string input)
        {
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                    return "Cut";
                else
                    return "Tek";
            }
            else
            {
                return "Error";
            }
        }

        // Task 4
        public static string MenfiMusbet(string input)  

        {
            if (double.TryParse(input, out double number))
            {
                if (number > 0)
                    return "Musbet";
                else if (number < 0)
                    return "Menfi";
                else
                    return "Sifir";
            }
            else
            {
                return "Error";
            }
        }
        // Task 5
        public static int Ters(int number)
        {
            int rnum = 0;
            int c;

            while (number != 0)
            {
                c = number % 10;
                rnum = rnum * 10 + c;
                number /= 10;
            }

            return rnum;
        }

        // Task 6
        public static int Hundred(int number)
        {
            int hundreds1 = number / 100;
            int tens1 = (number / 10) % 10;
            int ones1 = number % 10;

            int a = hundreds1 * 100;
            int b = tens1 * 10;

            Console.Write(a + " + " + b + " + " + ones1 + "---- ");

            return number;

        }

        // Task 7,8
        public static string TersString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string SozTers(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = TersString(words[i]);
            }
            return string.Join(" ", words);
        }
        
        // Task 9
        public static string LongWord(string input)
        {

                string[] words = input.Split(' ');
                string longestWord = "";

                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                        longestWord = word;
                }

                return longestWord;
            

        }
        // Task 10
        public static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        // Task 11
        public static string CapitalizeWords(string input)
        {

            if (string.IsNullOrEmpty(input))
                return input;

            string[] sentences = input.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Trim().Split(' ');
                if (words.Length > 0)
                {
                    words[0] = char.ToUpper(words[0][0]) + words[0].Substring(1);
                    sentences[i] = string.Join(" ", words);
                }
            }

            return string.Join(".", sentences);
        }

        // Task 12
        public static string SwapCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsUpper(c))
                {
                    result[i] = char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    result[i] = char.ToUpper(c);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }

        // Task 13
        public static string RemoveSait(string input)
        {
            
            string vowels = "aeiouAEIOU";

            char[] result = new char[input.Length];
            int index = 0;

            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    result[index++] = c;
                }
            }

            return new string(result, 0, index);
        }


        //task 14
        public static string ReduceSpaces(string input)
        {
            string[] words = input.Trim().Split(" ");

            return string.Join(" ", words);
        }

        //Task 15

        public static int Limit( int z)
        {
            int x = 10;
            int y = 5;

            int a = x + z;
            int b = y + z;
            Console.WriteLine(a);
            return b;
            
        }

        // Task 16
        public static void Lim()
        {
            int x = 20;
            int y = 25;

            int a = x + y - x;
            int b = y + x -y;
            Console.WriteLine("x = " + a);
            Console.WriteLine("y = " + b);

        }





        // Task 17

        public static int Dein(int a)
        {
            Console.WriteLine("Enter a number:");
            int min = (int)Math.Pow(10, a - 1);
            int max = (int)Math.Pow(10, a);

            Random rand = new Random();
            int randomNumber = rand.Next(min, max);

            

            return randomNumber;
        }

        // Task 18

        public static string Password(int lenght)
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] password = new char[lenght];
            for(int i=0; i< lenght; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);

        }

    

    //task 19
    public static int Task(int input)
        {
            Random r = new Random();
            int usud = r.Next(0, 10);

            for (int i = 0; i < 3; i++)
            {

                if (input==usud){
                    Console.WriteLine("Qazandiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("Bir daha sinayin");
                }

            }

            return -1;

        }
        
        



    }
}
