Console.WriteLine("Enter a number");
string number = Console.ReadLine();
int ParsedNumber = int.Parse(number);
// Making an array from 1 to a given number
int[] nums = new int[ParsedNumber];
int i = 0;
while (i < ParsedNumber) {
    nums[i] = i + 1;
    i++;
}
// Choosing all evens
int count = 0;
while(count < nums.Length) {
    int x = nums[count] % 2;
    if(x == 0) {
        Console.WriteLine(nums[count]);
    }
    
    count++;
}
