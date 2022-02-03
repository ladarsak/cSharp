Console.WriteLine("Enter number1");
string number1 = Console.ReadLine();
Console.WriteLine("Enter number2");
string number2 = Console.ReadLine();

int parsed1 = int.Parse(number1);
int parsed2 = int.Parse(number2);

if(parsed1 > parsed2) {
    Console.Write(parsed1);
    Console.Write(" is bigger than");
    Console.Write(parsed2);
}
else if(parsed2 > parsed1) {
    Console.Write(parsed2);
    Console.Write(" is bigger than");
    Console.Write(parsed1);
}
else {
    Console.Write("they are equal!");
}

//Console.WriteLine(number1);
//Console.WriteLine(number2);
//Console.WriteLine(parsed1 + parsed2);