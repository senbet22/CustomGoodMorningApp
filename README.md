# Custom GoodMorning App

A simple C# console application that greets the user based on the time of day and their mood.

## What it does

- Asks the user for their name
- Reads the current hour and looks up a matching greeting (morning, midday, afternoon, evening, or night)
- Asks the user how they are feeling (prompts user for input).
- Responds with a personalised message including the current day of the week in Norwegian.

## Technologies

- C# / .NET 10.0 +
- `System.Globalization` for Norwegian date formatting
- `Dictionary<string, string>` for greeting lookup
- Switch expressions for time-of-day and mood logic

## How to run
```bash
dotnet run
```
# Flowchart
  
<img src="public/flowchart.png" alt="CustomGoodMorningApp
 Flow Chart" width="720"/>
