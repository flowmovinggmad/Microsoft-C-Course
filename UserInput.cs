string? userRole;
bool validRole = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");

do
{

    userRole = Console.ReadLine();

    if (userRole.ToLower() == "administrator")
    {
        validRole = true;
        Console.WriteLine($"Your input value '{userRole}' has been accepted");
        break;
    } else if (userRole.ToLower() == "manager")
    {
        validRole = true;
        Console.WriteLine($"Your input value '{userRole}' has been accepted");
        break;
    } else if (userRole.ToLower() == "user")
    {
        validRole = true;
        Console.WriteLine($"your input value '{userRole}' has been accepted.");
        break;
    } else
    {
        Console.WriteLine($"The role name that you entered, '{userRole}' is not valid. Enter your role name (Administrator, Manager, or User).");
    }

} while (validRole == false);

Console.ReadKey();
