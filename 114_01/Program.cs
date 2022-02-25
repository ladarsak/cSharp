int[] arr = new int[8];
int i = 0;
int x = arr.Length;

while(i < x){
    arr[i] = new Random().Next(0, 2);
    Console.Write(arr[i]);
    i++;
}