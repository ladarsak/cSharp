// 1st group
/*void Method1()
    {
        Console.WriteLine("MyCopyright");
    }*/
//Method1();


// 2d group
/*void Method2(string msg, int count)
    {
        int i = 0;
        while(i < count){
            Console.WriteLine($"{msg} {i}");
            i++;
        }
        
    }*/
//Method2(msg: "Hello World", count: 3);

// 3d group
/*int Method3()
    {
        return DateTime.Now.Year;
        }
int year = Method3();
Console.WriteLine(year);*/

//4th group
/*string Method4(int count, string c)
    {
        string result = "";
        for(int i = 0; i < count; i++){
            result = result + c;            
        }
        return result;
    }
string res = Method4(c: "w", count: 3);
Console.WriteLine(res);*/

//Таблица умножения
for(int i = 2; i < 10; i++){
    for(int j = 2; j < 10; j++){
            Console.WriteLine($"{i} * {j} = {i * j}");  
                     
        }
        Console.WriteLine(""); 
    }
