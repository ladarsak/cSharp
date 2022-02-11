int num = new Random().Next(1, 1000);
string numString = num.ToString();
Console.WriteLine(num);
Console.WriteLine("let's look for the third position...");
if(numString.Length < 3){
    Console.WriteLine("there is no third position in this number");
}
else {
    Console.WriteLine(numString[2]);
}


