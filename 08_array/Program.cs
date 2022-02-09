void FillArray (int[] collection) {
    int length = collection.Length;
    int i = 0;
    while(i < length) {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray (int[] collection) {
    int length = collection.Length;
    int i = 0;
    while(i < length) {
        Console.WriteLine(collection[i]);
        i++;
    }
}

int IndexFind (int[] collection, int find) {
    int length = collection.Length;
    int i = 0;
    int position = 0;
    while(i < length){
        if(collection[i] == find){
            position = i;
            break;
        }
        i++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
int find = new Random().Next(1, 10);
Console.WriteLine("find: ");
Console.WriteLine(find);
int pos = IndexFind(array, find);
Console.WriteLine(pos);


/*int[] array = {1,2,3,4,5,6,7,4};
int n = array.Length;
int find = 4;
int index = 0;
while(index < n) {
    if(array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}*/