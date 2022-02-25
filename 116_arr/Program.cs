int[] arr = {1, 2, 3, 4};
int i = 0;
int j = arr.Length -1;
while(i < j){
    int change = arr[j];
    arr[j] = arr[i];
    arr[i] = change;
    i++;
    j--;
}

for(i = 0; i < arr.Length; i++){
    Console.WriteLine(arr[i]);
}