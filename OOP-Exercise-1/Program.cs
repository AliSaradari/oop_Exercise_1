using OOP_Exercise_1;
while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void Run()
{
    Console.WriteLine("Choose An Option:\n" +
        "1.Enter Person Information\n" +
        "0.Exit");
    int menu = int.Parse(Console.ReadLine()!);
    switch (menu)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            var firstName = GetString("Enter Firstname:");
            var lastName = GetString("Enter Lastname:");
            Main.AddPerson(firstName!, lastName!);
            Main.GetFullName();
            Console.WriteLine("------------------");
            break;
        default:
            Console.WriteLine("Invalid Option! Please Try Again.");
            break;
    }

    static string? GetString(string message)
    {
        Console.WriteLine(message);
        var input = Console.ReadLine();
        return input;
    }
}
