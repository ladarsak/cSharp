string[] week = {"Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Suturday", "Sunday",};
Console.WriteLine("Please enter a number from 1 to 7");
string DayNumber = Console.ReadLine();
int ParsedDayNumber = int.Parse(DayNumber);
//Console.WriteLine(ParsedDayNumber);

int i = ParsedDayNumber - 1;
//Console.WriteLine(i);
Console.Write("The ");
Console.Write(ParsedDayNumber);
Console.Write(" th day is ");
Console.Write(week[i]);