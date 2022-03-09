/*string NumbersFor(int a, int b){
    string result = string.Empty;
    for (int i = a; i < b; i++)
    {
        result += $"{i}, ";
    }
    return result;
}

Console.Write(NumbersFor(1, 10));*/

/*string NumbersRec(int a, int b){
    if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.Write(NumbersRec(20, 10));*/

/*int SumRec(int n){
    if(n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(3));*/

int[] data = {0, 1, 2, 3, 4, 5, 6, 7, 8 };
int[] info = {2, 3, 3, 1 };
int[] bit = new int[info.Length];
int n;

int beginWithData = 0;
int beginWithInfo = 0;
int continueWithData = 0; // предыдущее значение bWI

for (int i = 0; i < info.Length; i++)
{
    
    for (int k = info[i]; k < data.Length; k++)
    {
        for (int z = 0; z < k; z++)
        {
            bit[i] = bit[i] + data[z];
        }
        
        Console.WriteLine(bit[i]);
        //Console.WriteLine(n);
    }
    
  
}