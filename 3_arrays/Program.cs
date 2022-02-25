int[] arr = new int[8];
int i = 0;
int x = arr.Length;
int even = 0;
int uneven = 0;

while(i < x){
    arr[i] = new Random().Next(100, 1000);
    if(arr[i] % 2 == 0){
        even = even + 1;
    }
    else{
        uneven = uneven + 1;
    }
    Console.WriteLine(arr[i]);
    i++;
}
Console.WriteLine($"even: {even}");
Console.WriteLine($"uneven: {uneven}");