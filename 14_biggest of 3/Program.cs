Console.WriteLine("Enter number1");
string number1 = Console.ReadLine();
Console.WriteLine("Enter number2");
string number2 = Console.ReadLine();
Console.WriteLine("Enter number3");
string number3 = Console.ReadLine();

int parsed1 = int.Parse(number1);
int parsed2 = int.Parse(number2);
int parsed3 = int.Parse(number3);

int[] nums = new int[] {parsed1, parsed2, parsed3};
int large = nums[0];
int i = 0;

while (i < nums.Length) {
    if(nums[i] > large) {
        large = nums[i];
    }
    i++;
}
Console.Write("The biggest is ");
Console.Write(large);
