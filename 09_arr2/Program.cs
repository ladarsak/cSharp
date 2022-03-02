/*string[,] table = new string[2, 3];
table[0, 0] = "qq"; table[0, 1] = "ww"; table[0, 2] = "ee";
table[1, 0] = "aa"; table[1, 1] = "ss"; table[1, 2] = "dd";

for(int rows = 0; rows < 2; rows++){
    for(int columns = 0; columns < 3; columns++){
        Console.WriteLine($"{table[rows, columns]}");
}
}*/



/*void PrintArray(int[,] matrix){
for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($" {matrix[i, j]}");
}
Console.WriteLine();
}
}*/

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}
int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
Console.WriteLine($"{rows}, {columns}");
int[,] matr = new int[rows, columns];
FillArray(matr);