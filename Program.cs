using System;
// CSI2312 - Foundations of Software Engineering
// 
// Code for the git question of the assessment - enjoy!
//
// Edith Cowan University, 2024 - Martin Masek

namespace CSI2312_FinalAssessment
{
    class Program
    {
        static void Task01(int[] data)
        {
            int sum = 0;
            foreach (int num in data)
            {
                sum += num;
            }
            Console.WriteLine($"The sum of the data is: {sum}");
            Console.WriteLine("Press any key to continue...");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        }

        static void Task02(int[] data)
        {
            int sum = 0;
            foreach (int num in data)
            {
                sum += num;
            }
            double avg = (double)sum / data.Length;
            Console.WriteLine($"The average of the data is: {avg}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Task03(int[] data)
        {
            int min = data[0];
            foreach (int num in data)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"The minimum value in the data is: {min}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Task04(int[] data)
        {
            int max = data[0];
            foreach (int num in data)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The maximum value in the data is: {max}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // Define some data
            int[] data = { 1, 2, 3, 4, 5, 6 };

            // Menu loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine("This is the submission of: [Pahanmi Samaraweera]\n");

                // Display current data
                int index = 0;
                Console.Write("The current data is: [");
                foreach (int x in data)
                {
                    Console.Write(x);
                    index++;
                    if (index < data.Length)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.WriteLine("]\n");
                    }
                }

                Console.WriteLine("=============================");
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("(1) Calculate Sum");
                Console.WriteLine("(2) Calculate Average");
                Console.WriteLine("(3) Find Minimum");
                Console.WriteLine("(4) Find Maximum");
                Console.WriteLine("(5) Exit");
                Console.WriteLine("=============================");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Task01(data); // Sum
                        break;
                    case 2:
                        Task02(data); // Average
                        break;
                    case 3:
                        Task03(data); // Minimum
                        break;
                    case 4:
                        Task04(data); // Maximum
                        break;
                    case 5:
                        // Exit the loop
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
