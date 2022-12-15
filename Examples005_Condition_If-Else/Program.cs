Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "Masha")
{
    Console.WriteLine("Yay, its Masha!");   
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
}