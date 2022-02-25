int number = new Random().Next(10, 101);
Console.WriteLine(number);
int sum = 0;
while(number > 0){
    sum = sum + number % 10;
    number = number / 10;
}

Console.WriteLine(sum);