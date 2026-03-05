try
{
    bool exit = false;

    while (!exit)
    {

        Console.WriteLine("Menu:");
        Console.WriteLine("1. Enter Student ID and Name");
        Console.WriteLine("2. Exit");
        Console.Write("Please select an option (1 or 2): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
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