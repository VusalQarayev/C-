using System.Globalization;
using System.Xml.Linq;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Task 21 ----");

            Console.WriteLine("Array daxilindeki elementleri sayi:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Daxil edin {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = Sum(arr);
            Console.WriteLine($"Array daxilindeki elementlerin cemi: {result}");
            Console.WriteLine();


            Console.WriteLine("---- Task 22 ----");
            Console.WriteLine(CountWords("Baki gozel seherdir"));
            Console.WriteLine();

            Console.WriteLine("---- Task 23 ----");
            int[] ints = { 1, 2, 3, 4, 5 ,10 ,20 };
            Bol5(ints);
            Console.WriteLine();

            Console.WriteLine("---- Task 24 ----");
            int[] inta = {  15, 10, 20 };
            Console.WriteLine( EdediOrta(inta));
            Console.WriteLine();

            Console.WriteLine("---- Task 25 ----");
            string[] names = { "Aytac", "Babek", "Kazim", "Hesen", "Gozel","Hecer" };
            foreach (string i in names) {
                if (i.ToLower().Contains('a'))
                {
                    Console.WriteLine(i);
                   

                }
               
                
            }
            Console.WriteLine();
            Console.WriteLine("---- Task 26 ----");
            int[] numbers = { 3, 5, 7, 2, 8, 6, 4, 10, 9 };

            int maxNumber = ArrayMax(numbers);

            Console.WriteLine("Array max element: " + maxNumber);


            Console.WriteLine();
            Console.WriteLine("---- Task 27 ----");
            int[] numbers2 = { 5, 2, 9, 1, 7 };
            SwapMaxMin(numbers2);
            Console.WriteLine("Yeni array: " + string.Join(", ", numbers2));

            Console.WriteLine();
            Console.WriteLine("---- Task 28 ----");

            int[] numbers1 = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[] numbers3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(FibonacciArr(numbers1) + " ilk array");
            Console.WriteLine(FibonacciArr(numbers3) + " ikinci array");

            Console.WriteLine();
            Console.WriteLine("---- Task 29 ----");

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 5, 4, 3, 2, 1 };
            int[] arr3 = { 1, 2, 3, 4, 6 };

            Console.WriteLine(Similar(arr1, arr2)); // Output: true
            Console.WriteLine(Similar(arr1, arr3)); // Output: false

            Console.WriteLine();
            Console.WriteLine("---- Task 30 ----");

            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine(NumberToWords(numb));

            Console.WriteLine();
            Console.WriteLine("---- Task 31 ----");
            int[] array = { 5, 3, 8, 4, 2 };
            Sort(array, "azalan");


            Console.WriteLine();
            Console.WriteLine("---- Task 32 ----");
            PlayGame();

            Console.WriteLine();
            Console.WriteLine("---- Task 33 ----");

            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine().ToLower();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine().ToLower();

            if (AreAnagrams(word1, word2))
            {
                Console.WriteLine("The words are anagrams.");
            }
            else
            {
                Console.WriteLine("The words are not anagrams.");
            }
            Console.WriteLine();
            Console.WriteLine("---- Task 34 ----");

            Console.Write("Enter a word: ");
            string word = Console.ReadLine().ToLower();

            FindVowelsAndConsonants(word);

            Console.WriteLine();
            Console.WriteLine("---- Task 35 ----");
            int target = 12;
            FindCombinations(target);

            Console.WriteLine();
            Console.WriteLine("---- Task 36 ----");
            FindCombinations2(target);


            Console.WriteLine();
            Console.WriteLine("---- Task 37 ----");
            int[] arr4 = new int[10];
            Random random = new Random();

            // Fill the array with random numbers
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = random.Next(1, 101); // Random numbers between 1 and 100
                Console.Write($"{arr4[i]} ");
            }

            Console.WriteLine();

            int minValue = arr4[0];
            int sumExceptMinimum = 0;

            // Find the minimum value and sum of all elements except the minimum
            for (int i = 0; i < arr4.Length; i++)
            {
                if (arr4[i] < minValue)
                {
                    minValue = arr4[i];
                }
                else
                {
                    sumExceptMinimum += arr4[i];
                }
            }

            Console.WriteLine($"Minimum value: {minValue}");
            Console.WriteLine($"Sum of all elements except the minimum: {sumExceptMinimum}");

            Console.WriteLine();
            Console.WriteLine("---- Task 38 ----");
            int[] arr7 = { 1, 2, 6, 0, 4, 5, 6, 0, 9, 0, 12, 23, 0 };
            Console.WriteLine(CountElementsBetweenZeros(arr7));

            Console.WriteLine();
            Console.WriteLine("---- Task 39 ----");

            int[] arr9 = { -5, 0, 3, -2, 7, 0, -1, 9, 4 };

            int minPositive = FindMinimumPositive(arr9);

            if (minPositive == int.MaxValue)
            {
                Console.WriteLine("No positive numbers found in the array.");
            }
            else
            {
                Console.WriteLine($"The minimum positive number in the array is: {minPositive}");
            }


            Console.WriteLine();
            Console.WriteLine("---- Task 40 ----");

            DateTime randomDate = GenerateRandomDate();
            if (randomDate != default(DateTime))
            {
                Console.WriteLine(randomDate.ToString("yyyy-MM-dd"));
            }

            Console.WriteLine();
            Console.WriteLine("---- Task 41 ----");

            Console.Write("Enter a date (yyyy-MM-dd): ");
            DateTime date = GetValidDate();

            string weekday = GetWeekday(date);
            Console.WriteLine($"The weekday for {date:yyyy-MM-dd} is {weekday}.");

            Console.WriteLine();
            Console.WriteLine("---- Task 42 ----");

            Console.WriteLine("Enter the start date (yyyy-MM-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end date (yyyy-MM-dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            int numberOfWeekdays = CountWeekdays(startDate, endDate);
            Console.WriteLine($"Number of weekdays between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd} is: {numberOfWeekdays}");



        }


        // Task 21

        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }


        // Task 22

        public static int CountWords(string sentence)
        {

            return sentence.Split().Length;
        }

        // Task 23

        public static void Bol5(int[] arr)
        {
            bool found = false;
            foreach (int num in arr)
            {
                if (num % 5 == 0)
                {
                    Console.Write(num + " ");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Massivde 5-e bolunen eded yoxdur.");
            }
        }

        // Task 24

        public static int EdediOrta(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (int)sum / arr.Length;
        }

        // Task 26
         public static int ArrayMax(int[] array)
        {
            int max = array[0];

            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        // Task 27
        public static void SwapMaxMin(int[] arr)
        {
            int maxIndex = Array.IndexOf(arr, arr.Max());
            int minIndex = Array.IndexOf(arr, arr.Min());

            int temp = arr[maxIndex];
            arr[maxIndex] = arr[minIndex];
            arr[minIndex] = temp;
        }

        // Task 28

        public static bool FibonacciArr(int[] arr)
        {
            int a = 0, b = 1;

            foreach (int num in arr)
            {
                if (num != a && num != b)
                {
                    while (b < num)
                    {
                        int temp = b;
                        b = a + b;
                        a = temp;
                    }

                    if (num != b)
                        return false;
                }
            }

            return true;
        }

        // Task 29
        public static bool Similar(int[] arr1, int[] arr2)
        {
            
            if (arr1.Length != arr2.Length)
                return false;

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        // Task 30

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "sıfır";

            string words = "";
            string[] units = { "sifir", "bir", "iki", "uc", "dord", "bes", "altı", "yeddi", "sekkiz", "doqquz", "on", "on bir", "on iki", "on uc", "on dord", "on bes", "on alti", "on yeddi", "on sekkiz", "on doqquz" };
            string[] tens = { "", "", "iyirmi", "otuz", "qırx", "elli", "altmış", "yetmis", "seksen", "doxsan" };

            if (number < 0)
            {
                words = "minus ";
                number = -number;
            }

            if (number / 1000000000 > 0)
            {
                words += NumberToWords(number / 1000000000) + " milyard ";
                number %= 1000000000;
            }

            if (number / 1000000 > 0)
            {
                words += NumberToWords(number / 1000000) + " milyon ";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                words += NumberToWords(number / 1000) + " min ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += units[number / 100] + " yuz ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    words += units[number];
                else
                {
                    words += tens[number / 10];
                    if (number % 10 > 0)
                        words += " " + units[number % 10];
                }
            }

            return words.Trim();
        }

        // Task 31

        
        public static void Sort(int[] arr, string sort)
        {
            int count = arr.Length - 1;

            while (count > 0)
            {
                int loopCount = 0;

                if (sort == "artan")
                {
                    for (int i = loopCount; i < arr.Length; i++)
                    {
                        if (i != arr.Length - 1 && arr[i] > arr[i + 1])
                        {
                            Swap(arr, i);
                        }
                    }
                }
                else if (sort == "azalan")
                {
                    for (int i = loopCount; i < arr.Length; i++)
                    {
                        if (i != arr.Length - 1 && arr[i] < arr[i + 1])
                        {
                            Swap(arr, i);
                        }
                    }
                }
                else
                {
                    return;
                }

                loopCount++;
                count--;
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Swap(int[] arr, int i)
        {
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }




        //  Task 32


        static void PlayGame()
        {
            int userChoice, computerChoice;
            string[] choices = { "Rock", "Paper", "Scissors" };
            Random random = new Random();

            Console.Write("Choose Rock, Paper, or Scissors (r/p/s): ");
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "r":
                    userChoice = 0;
                    break;
                case "p":
                    userChoice = 1;
                    break;
                case "s":
                    userChoice = 2;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            computerChoice = random.Next(0, 3);

            Console.WriteLine($"You chose {choices[userChoice]}.");
            Console.WriteLine($"Computer chose {choices[computerChoice]}.");

            DetermineWinner(userChoice, computerChoice, choices);
        }

        static void DetermineWinner(int userChoice, int computerChoice, string[] choices)
        {
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a draw!");
            }
            else if ((userChoice == 0 && computerChoice == 2) ||
                     (userChoice == 1 && computerChoice == 0) ||
                     (userChoice == 2 && computerChoice == 1))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }


        // Task 33

        static bool AreAnagrams(string word1, string word2)
        {
            
            var chars1 = new string(word1.Where(char.IsLetter).ToArray());
            var chars2 = new string(word2.Where(char.IsLetter).ToArray());

            Array.Sort(chars1.ToCharArray());
            Array.Sort(chars2.ToCharArray());

            return new string(chars1.ToCharArray()) == new string(chars2.ToCharArray());
        }

        // Task 34
        static void FindVowelsAndConsonants(string word)
        {
            List<char> vowels = new List<char>();
            List<char> consonants = new List<char>();

            foreach (char c in word)
            {
                if (IsVowel(c))
                {
                    vowels.Add(c);
                }
                else if (char.IsLetter(c))
                {
                    consonants.Add(c);
                }
            }

            Console.WriteLine($"Vowels: {string.Join(", ", vowels)}");
            Console.WriteLine($"Consonants: {string.Join(", ", consonants)}");
        }

        static bool IsVowel(char c)
        {
            return "aeiou".Contains(c);
        }

        // Task 35

        static void FindCombinations(int target)
        {
            Console.WriteLine($"Combinations of two numbers that sum up to {target}:");

            for (int i = 1; i <= target / 2; i++)
            {
                int j = target - i;
                Console.WriteLine($"{i} + {j}");
            }
        }

        // Task 36
        public static void FindCombinations2(int target)
        {
            Console.WriteLine($"Combinations of three numbers that sum up to {target}:");

            for (int i = 1; i <= target - 2; i++)
            {
                for (int j = i + 1; j <= target - 1; j++)
                {
                    int k = target - i - j;
                    Console.WriteLine($"{i} + {j} + {k}");
                }
            }
        }

        // Task 38

        public static int CountElementsBetweenZeros(int[] arr)
        {
            int firstZeroIndex = -1;
            int lastZeroIndex = -1;

            // Find the indices of the first and last occurrence of 0
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    if (firstZeroIndex == -1)
                    {
                        firstZeroIndex = i;
                    }
                    else
                    {
                        lastZeroIndex = i;
                    }
                }
            }

            // If there are no zeros or only one zero, return 0
            if (firstZeroIndex == -1 || lastZeroIndex == -1 || firstZeroIndex == lastZeroIndex)
            {
                return 0;
            }

            // Count the elements between the first and last occurrence of 0
            int count = 0;
            for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
            {
                count++;
            }

            return count; 
        }

        // Task 39

        static int FindMinimumPositive(int[] arr)
        {
            int minPositive = int.MaxValue;

            foreach (int num in arr)
            {
                if (num > 0 && num < minPositive)
                {
                    minPositive = num;
                }
            }

            return minPositive;
        }

        // Task 40

        public static DateTime GenerateRandomDate()
        {
            Console.Write("Enter the start date (yyyy-MM-dd): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

            Console.Write("Enter the end date (yyyy-MM-dd): ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

            if (startDate > endDate)
            {
                Console.WriteLine("Invalid date range. Start date must be earlier than end date.");
                return default(DateTime);
            }

            TimeSpan timeSpan = endDate - startDate;
            Random random = new Random();
            int randomDays = random.Next((int)timeSpan.TotalDays + 1);

            DateTime randomDate = startDate.AddDays(randomDays);
            return randomDate;
        }

        // Task 41

        static DateTime GetValidDate()
        {
            while (true)
            {
                if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime result))
                    return result;

                Console.Write("Invalid date format. Please enter a date in the format (yyyy-MM-dd): ");
            }
        }

        static string GetWeekday(DateTime date)
        {
            string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            return weekdays[(int)date.DayOfWeek];
        }


        // Task 42

        public static int CountWeekdays(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("Start date must be earlier than or equal to end date.");
            }

            int weekdayCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    weekdayCount++;
                }
            }
            return weekdayCount;
        }


    }
}
