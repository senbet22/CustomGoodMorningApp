using System.Globalization;

// Set the culture to Norwegian for date formatting.
CultureInfo norwegian = new CultureInfo("nb-NO");

Console.WriteLine("Hei, Velkommen til Godmorgen APP!");
Console.WriteLine("///////////////////////////////");

string name = "";
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Hva heter du?");
    name = Console.ReadLine() ?? "";
}
// Get the current day of the week and time of day.
string today = DateTime.Now.ToString("dddd", norwegian);
int timeOfDay = DateTime.Now.Hour;

Dictionary<string, string> greetings = new Dictionary<string, string>
{
    { "morgen", $"God morgen, {name}!"},
    { "formiddag", $"God Formiddag, {name}!"},
    { "ettermiddag", $"God ettermiddag, {name}!"},
    { "kveld", $"God kveld, {name}!"},
    { "natt", $"Hei {name}, Det er kanskje på tide å legge seg."}
};

// Determines the appropriate greeting based on the time of day. using switch expression.
string key = timeOfDay switch
{
    >= 6 and < 9 => "morgen",
    >= 9 and < 12 => "formiddag",
    >= 12 and < 18 => "ettermiddag",
    >= 18 and < 22 => "kveld",
    _ => "natt"
};
// Print the appropriate greeting.
Console.WriteLine(greetings[key]);

Console.WriteLine("///////////////////////////////");
Console.WriteLine("Hvordan har du det i dag? B = bra, O = okay og D = dårlig");
string mood = (Console.ReadLine() ?? "").Trim().ToLower();


string moodMessage = mood switch
{
    "b" => $"Så bra å høre! ha en fin {today}!",
    "o" => $"Ok er bra nok! ha en fin {today}!",
    "d" => $"Håper {today}en din blir bedre!",
    _ => $"Jeg forstod ikke svaret ditt, men ha en fin {today}!"
};
// Print the appropriate mood message.
Console.WriteLine(moodMessage);

// Wait for user input before closing the console.
Console.ReadKey();