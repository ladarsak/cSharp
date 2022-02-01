Console.WriteLine("What's Your Name?");
string username = Console.ReadLine();
//Console.WriteLine(username);
if(username.ToLower() == "dima") {
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
else {
    Console.WriteLine("Hello, I Don't Know you");
}