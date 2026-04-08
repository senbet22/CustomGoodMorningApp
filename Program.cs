Console.WriteLine("Hello, Welcome to Greetings App!");
Console.WriteLine("///////////////////////////////");

string name = "";
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Please enter your name!");
    name = Console.ReadLine() ?? "";
}

DayOfWeek today = DateTime.Now.DayOfWeek;
int timeOfDay = DateTime.Now.Hour;


Dictionary<string, string> greetings = new Dictionary<string, string>
{
    { "morgen", $"God morgen, {name}!"},
    { "formiddag", $"God Formiddag, {name}!"},
    { "ettermiddag", $"God ettermiddag, {name}!"},
    { "kveld", $"God kveld, {name}!"},
    { "natt", $"Hei {name}, Det er kanskje på tide å legge seg."}
};


string key = timeOfDay switch
{
    >= 6 and < 9 => "morgen",
    >= 9 and < 12 => "formiddag",
    >= 12 and < 18 => "ettermiddag",
    >= 18 and < 22 => "kveld",
    _ => "natt"
};

Console.WriteLine(greetings[key]);