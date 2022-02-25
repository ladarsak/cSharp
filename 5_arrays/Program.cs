int[] arr = {1, 10, 3, 15, 5};
int i = 0;
int x = arr.Length;
int min = arr[0];
int max = arr[0];

while(i < x){
    if(arr[i] > max){
        max = arr[i];   
    }
    i++;
}

while(i < x){
    if(min > arr[i]){
        min = arr[i];   
    }
    i++;
}
int result = max - min;
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine($"{max} - {min} = {result}");