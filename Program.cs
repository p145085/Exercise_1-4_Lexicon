namespace Exercise_1_4_Lexicon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1.
            // Write a program and ask the user to enter a number.
            // The number should be between 1 to 10.
            // If the user enters a valid number, display "Valid" on the console.
            // Otherwise, display "Invalid".
            // (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            Console.WriteLine("Enter a number between 1-10.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Great.");
            } else
            {
                Console.WriteLine("You're doing it wrong.");
            }
            // End of Exercise 1.

            // Exercise 2.
            // Write a program and ask the user to enter a number.
            // The number should be between 1 to 10.
            // If the user enters
            // MESSAGE CUT SHORT. ABORT.

            // End of Exercise 2.

            // Exercise 3.
            // Write a program and ask the user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait.

            Console.WriteLine("Enter the WIDTH of your image.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the HEIGHT of your image.");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Your image is of the format 'Landscape'.");
            } else if (height > width)
            {
                Console.WriteLine("Your image is of the format 'Portrait'.");
            } else if (height == width)
            {
                Console.WriteLine("Your image is a square.");
            }

            // End of Exercise 3.

            // Exercise 4.
            //Write a program for a speed camera.
            //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car.
            //If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of failurepoints.
            //For every 5km/hr above the speed limit, 1 failurepoints should be incurred and displayed on the console.
            //If the number of failurepoints is above 12, the program should display License Suspended.

            Console.WriteLine("Enter your speed (in km/h).");
            double speed = Convert.ToDouble(Console.ReadLine());
            double speedLimit = 70;
            double transgression = speed - speedLimit;

            if (speed <= speedLimit)
            {
                Console.WriteLine("OK.");
            } else if (speed > speedLimit)
            {
                double perFiveOver = transgression % 5;
                Console.WriteLine("Your transgression value is " + perFiveOver);
            }

            if (transgression >= 12)
            {
                Console.WriteLine("License suspended.");
            }
            // End of Exercise 4.

        }
    }
}