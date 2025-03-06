// Define the namespace for our program 
namespace UserAndPass;

// Define the main Program class that contains the entry point
class Program
{
    // The Main method - entry point of the application that takes command line arguments
    static void Main(string[] args)
    {
        // Create a new instance of the Login class
        Login login = new Login();

        // Display prompt for username input
        Console.Write("Enter Username: ");
        // Read the user's input and store it in the Username property
        login.Username = Console.ReadLine();

        // Display prompt for password input
        Console.Write("Enter Password: ");
        // Read the user's input and store it in the Password property
        login.Password = Console.ReadLine();

        // Call the Submit method to process the login attempt
        login.Submit();
    }
}