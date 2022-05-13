List<string> firstName = new ();
string? insert;

do
{
    Console.Write("Enter a first name. Type end to quit: ");
    insert = Console.ReadLine();

    //checks for no name entry
    if (string.IsNullOrEmpty(insert))
    {
        Console.WriteLine("You must enter a name!");
    }
    else if (insert != "end")
    {
        
        firstName.Add(insert);
    }

} while (insert != "end");

Console.WriteLine("\n");

foreach (var name in firstName)
{
    Console.WriteLine($"Hello {name}");
}