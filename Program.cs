Console.WriteLine("Hello, Welcome to Greetings App!");
Console.WriteLine("///////////////////////////////");

Console.WriteLine("Please enter your name!");
string userInputName = Console.ReadLine() ?? "";


Console.WriteLine("and now your age...");
string userInputAge = Console.ReadLine()?? "";


if (!int.TryParse(userInputAge, out int age))
{
    Console.WriteLine("Invalid input");
}



Console.WriteLine($"Good morning {userInputName}, You are {userInputAge} years old");





Dictionary<string, string> myDictionary = new Dictionary<string, string>
{
    { "morgen", "God morgen!"},
    { "formiddag", "God Formiddag!"},
    { "ettermiddag", "God ettermiddag!"},
    { "kveld", "God kveld!"},
    { "natt", "Hei! Det er ikke så sunt for deg å være oppe så lenge."}
};