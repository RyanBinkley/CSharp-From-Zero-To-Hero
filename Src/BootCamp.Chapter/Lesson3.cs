using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static float weight;
        static float height;

        public static void Demo()
        {
            BMICalculator("Person 1");
            BMICalculator("Person 2");
        }

        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / (height * height);

            if (height <= 0 || weight <= 0)
            {
                if (weight <= 0 && height <= 0)
                {
                    string error3 = $"Height cannot be equal or less than zero, but was {height}. Also, Weight cannot be equal or less than zero, but was {weight}.";
                    Console.WriteLine($"\nFailed calculating BMI. \nReason: " + error3);
                    return -1;
                }
                else if (height <= 0)
                {
                    string error1 = $"Height cannot be equal or less than zero, but was {height}.";
                    Console.WriteLine($"\nFailed calculating BMI. \nReason: " + error1);
                    return -1;
                }
                else if (weight <= 0)
                {
                    string error2 = $"Weight cannot be equal or less than zero, but was {weight}.";
                    Console.WriteLine($"\nFailed calculating BMI. \nReason: " + error2);
                    return -1;
                }

            }
            
            return bmi;
        }

        public static void BMICalculator(string person)
        {
            string name_first = PromptString("Hello! What's your first name? ");
            string name_last = PromptString("And your last name? ");
            int age = PromptInt("What is your age in years? ");
            height = PromptFloat("What is your height in meters?(eg. 1.72) ");
            weight = PromptFloat("What is your weight in kg?(eg. 80.2) ");

            float theBMI = CalculateBMI(weight, height);

            if (theBMI == -1)
            {
                Console.WriteLine("Failed calculating BMI.\n");
                return;
            }

            Console.WriteLine($"{name_first} {name_last} is {age} years old! Their weight is {weight} kgs, and their height is {height} meters!");
            Console.WriteLine($"After calculating it, your BMI comes out to {theBMI}!\n");
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);

            int number;
            string answer = Console.ReadLine();
            bool isNumber = int.TryParse(answer, out number);

            if (isNumber == true)
            {
                return number;
            }
            else
            {
                Console.WriteLine($"{answer} is not a valid number.");
                return -1;
            }

        }

        public static string PromptString(string message)
        {
            Console.Write(message);

            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else return text;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float number = float.Parse(Console.ReadLine());
            return number;
        }
    }
}
