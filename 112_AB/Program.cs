int a = new Random().Next(1, 11);
int b = new Random().Next(1, 11);
int c = a;

Console.WriteLine(a);
Console.WriteLine(b);

int i = 1;
while(i < b){
    c = c * a;
    i++;
}

Console.WriteLine($"{a} to the {b} power is {c}");