int a = new Random().Next(1, 11);
int c = 1;

Console.WriteLine(a);

int i = 1;
while(i < a){
    if(i % 2 == 0){
        c = i * i * i;
        Console.WriteLine($"{c}");
    }
    
    i++;
}