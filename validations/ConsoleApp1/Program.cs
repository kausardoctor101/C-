using System;
using System.Collections.Generic;


namespace validations
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.small3Numbers();
        }
        public void valid()
        {
            Console.WriteLine("Enter a number between 1 and 10:");
            int x = int.Parse(Console.ReadLine());
            if (x > 0 && x < 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void twoNumbers()
        {
            Console.WriteLine("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else if (x < y)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }
        }

        public void shape()
        {
            Console.WriteLine("Enter width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = int.Parse(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrate");
            }
        }

        public void speed()
        {
            Console.WriteLine("Enter the speed limit:");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter car speed");
            int speed = int.Parse(Console.ReadLine());
            if (speed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demeritPoints = (speed - speedLimit) / 5;
                if (demeritPoints < 12)
                {
                    Console.WriteLine($"Demerit Points: {demeritPoints}");

                }
                else
                {
                    Console.WriteLine("Licence Suspended");
                }

            }
        }

        public void divisable3()
        {
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    count = ++count;

                }
            }
            Console.WriteLine(count);
        }

        public void sum()
        {
            var sumofInputs = 0;
            while (true)
            {
                Console.WriteLine("Enter a number:");
                var input = Console.ReadLine();
                if (input == "OK" || input == "ok")
                {
                    break;
                }
                sumofInputs += int.Parse(input);
                Console.WriteLine($"Sum: {sumofInputs}");
            }
        }

        public void factorial()
        {
            var number = 1;
            Console.WriteLine("Enter a number:");
            var input = int.Parse(Console.ReadLine());
            var y = input;
            for (int i = 0; i < input; ++i)
            {
                number = number * y;
                --y;
            }
            Console.Write(input + $"! = {number}");
        }

        public void guessaNumber()
        {
            int i = 1;
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Guess a number:");
            var input = int.Parse(Console.ReadLine());
            while (i <= 4)
            {
                if (input == randomNumber)
                {
                    Console.WriteLine("YOU WON !!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Guess again:");
                    input = int.Parse(Console.ReadLine());
                    i++;
                }
            }
            if (i > 4)
            {
                Console.WriteLine("YOU LOST !!!!");
            }
        }

        public void maxNumber()
        {
            Console.WriteLine("Enter 5 numbers seperated by a coma:");
            string input = Console.ReadLine();
            String[] numbers = input.Split(",");
            var arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }
            int mNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (mNumber < arr[i])
                {
                    mNumber = arr[i];
                }
            }
            Console.WriteLine($"{mNumber}");
        }

        public void faceBook()
        {
            List<string> names = new List<string>();
            int i = 0;
            while (i == 0)
            {
                Console.Write("Enter Names: ");
                string theName = Console.ReadLine();
                if (theName != "")
                {
                    names.Add(theName);
                }
                else
                {
                    i = 1;
                }
            }

            if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " likes your post");
            }
            if (names.Count == 2)
            {
                Console.WriteLine(names[0] + " and " + names[1] + " likes your post");
            }
            if (names.Count > 2)
            {
                Console.WriteLine(names[0] + " and " + names[1] + " and number of other people likes your post");
            }
        }

        public void flipName()
        {
            //char[] name = new char[];
            Console.Write("Enter Names: ");
            string theName = Console.ReadLine();
            char[] name = theName.ToCharArray();
            char[] revName = new char[name.Length];
            int j = 0;
            Console.Write(name.Length);
            for (int i = name.Length; i !=0; i--)
            {
                revName[j] = name[i-1];
                j++;

            }
            string reverseName = new string(revName);
            Console.WriteLine("Reverse of Name: {0}", reverseName);
        }

        public void sortNumber()
        {
            int i = 0;
            List<int> numbers = new List<int>();
            while (i <= 4)
            {
                Console.WriteLine("Write a number:");
                var input = int.Parse(Console.ReadLine());
                bool Contains = numbers.Contains(input);
                if (!Contains)
                {
                    numbers.Add(input);
                    i++;
                }
                else
                {
                    Console.WriteLine("! Error This number already already exists try again");
                }
            }
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void uniqueList()
        {
            int i = 0;
            List<int> numbers = new List<int>();
            while (i != 1)
            {
                Console.WriteLine("Write a number:");
                var input = (Console.ReadLine());
                if (input != "Quit")
                {
                    var newInput = int.Parse(input);
                    numbers.Add(newInput);
                }
                else
                {
                    i = 1;
                }
            }
            i = 0;
            List<int> distinctElements = new List<int>();
            while (i < numbers.Count)
            {
                if (!distinctElements.Contains(numbers[i]))
                    distinctElements.Add(numbers[i]);
                i++;
            }
            distinctElements.Sort();
            foreach (int number in distinctElements)
            {
                Console.WriteLine(number);
            }
        }

        public void small3Numbers()
        {
            string[] stringInt()
            {
                bool condition = true;
                string[] num = new string[1] {"a"};
                string[] numbers;
                int arrLength = 0;
                while (condition == true)
                {
                    Console.WriteLine("Enter atleast 5 numbers seperated by a coma:");
                    string input = Console.ReadLine();
                    numbers = input.Split(",");
                    arrLength = numbers.Length;
                    if (numbers.Length == 0 || numbers.Length < 5)
                    {
                        Console.WriteLine("! Error try again");
                        Array.Clear(numbers, 0, numbers.Length);
                    }
                    else
                    {
                        return numbers;
                    }
                    
                }
                
                return num;
                
            }
            string[] arr = stringInt();
            int[] arrnew = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrnew[i] = int.Parse(arr[i]);
            }
            Array.Sort(arr);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
    }
}
