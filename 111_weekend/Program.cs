string[] week = {"Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Suturday", "Sunday",};
Console.WriteLine("Please enter a number from 1 to 7");
string DayNumber = Console.ReadLine();
int ParsedDayNumber = int.Parse(DayNumber);
//Console.WriteLine(ParsedDayNumber);

int i = ParsedDayNumber - 1;
if(i > 4){
    Console.WriteLine($"{week[i]} is a day off");
}
else {
    Console.WriteLine($"{week[i]} is not a day off");
}