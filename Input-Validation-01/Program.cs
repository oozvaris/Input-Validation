using System.Text.RegularExpressions;
using Input_Validation_01;

try
{
    bool exit = false;

    while (!exit)
    {

        Console.WriteLine("Menu:");
        Console.WriteLine("1. Enter Student ID and Name (Input Validation)");
        Console.WriteLine("2. Enter Student ID and Name (Error Handling)");
        Console.WriteLine("3. Verify Email (Regular Expressions)");
        Console.WriteLine("4. Verify Password (Regular Expressions)");
        Console.WriteLine("5. Exit");
        Console.Write("Please select an option (1 or 2): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "4":
                string password;

                // Ask user for password input
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Password is invalid. It must meet the following criteria:");
                Console.WriteLine("- At least 8 characters long");
                Console.WriteLine("- Contains at least one lowercase letter");
                Console.WriteLine("- Contains at least one uppercase letter");
                Console.WriteLine("- Contains at least one number");
                Console.WriteLine("- Contains at least one special character (e.g., @$!%*?&)");
                Console.Write("Enter a password: ");
                password = Console.ReadLine();

                // Regular Expression for password validation
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

                if (Regex.IsMatch(password, pattern))
                {
                    Console.WriteLine("Password is valid.");
                }
                else
                {
                    Console.WriteLine("Password is invalid. It must meet the following criteria:");
                    Console.WriteLine("- At least 8 characters long");
                    Console.WriteLine("- Contains at least one lowercase letter");
                    Console.WriteLine("- Contains at least one uppercase letter");
                    Console.WriteLine("- Contains at least one number");
                    Console.WriteLine("- Contains at least one special character (e.g., @$!%*?&)");
                }
                break;
            case "3":
                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                //string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
                // if (Regex.IsMatch(email, pattern))
                if (EmailValidation.IsValidEmail(email))
                {
                    Console.WriteLine("Valid email address.");
                }
                else
                {
                    Console.WriteLine("Invalid email address. Please enter a valid email.");
                }
                break;
            case "1":
                // Proceed to input validation
                Console.WriteLine("Enter Student ID:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int studentId))
                {
                    Console.WriteLine($"Student ID entered: {studentId}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for Student ID.");
                }
                break;
            case "2":
                try
                {
                    // Proceed to input validation with error handling
                    Console.WriteLine("Enter Student ID:");
                    string input1 = Console.ReadLine();
                    string input2 = Console.ReadLine();
                    int studentId1 = int.Parse(input1); // This will throw an exception if input is not a valid integer
                    int studentId2 = int.Parse(input2); // This will throw an exception if input is not a valid integer
                    Console.WriteLine($"Student ID entered: {studentId1 / studentId2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for Student ID.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message); // Handle the error
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
                break;
            case "5":
                exit = true;
                Console.WriteLine("Exiting the program. Goodbye!");
                continue;
            default:
                Console.WriteLine("Invalid option. Please select 1 or 2.");
                continue;
        }


    }

}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}