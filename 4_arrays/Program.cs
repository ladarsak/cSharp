// под нечетными позициями понимаются индексы [1, 3, ...]
int[] arr = {1, 10, 3, 15, 5};
int i = 1;
int x = arr.Length;
int uneven = 0;

while(i < x){
        uneven = uneven + arr[i];
        i+=2;
    }
   

for(i = 0; i < arr.Length; i++){
    Console.WriteLine(arr[i]);
}
Console.WriteLine($"sum of uneven numbers: {uneven}");