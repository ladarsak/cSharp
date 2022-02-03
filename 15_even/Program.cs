Console.WriteLine("Enter a number");
string number = Console.ReadLine();
int ParsedNumber = int.Parse(number);
double n = (double)ParsedNumber;
double x = n % 2;

if(x == 0) {
    Console.Write(n);
    Console.Write(" is even");
}
else {
    Console.Write(n);
    Console.Write(" is not even");
}