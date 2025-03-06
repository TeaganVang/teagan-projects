namespace UserAndPass;
public class Login
{
    // Properties to store the username and password
    public string Username; // Stores the username entered by the user
    public string Password;  // Stores the password entered by the user

    // The method to handle login submission
    public void Submit()
    {
        try
        {
            // Check if either the username or password is empty
            if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                // Throw an exception if validation fails
                throw new ArgumentException("Username or Password cannot be empty.");
            }

            // Check if input matches Admin account
            if(Username == "admin" && Password == "password")
            {
                // Displays success message for Admin login
                Console.WriteLine("Admin login successful!");
                // Wait for user to press Enter before continuing
                Console.ReadLine();
            }
            // Checks if input matches regular User account
            else if (Username == "user" && Password == "1234")
            {
                // Display success message for User login
                Console.WriteLine("User login successful!");
                // Wait for user to press Enter before continuing
                Console.ReadLine();
            }
            // Handles whether or not the inputs for login submission don't match any known accounts
            else
            {
                // Display error message for invalid credentials
                Console.WriteLine("Invalid username and password");
            }
        }
        // Catches and handles any exceptions that occurs during login
        catch (Exception ex)
        {
            // Displays the error message to the user
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}