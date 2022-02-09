int n = 234;
int i = 99;
int pos = 0;

while(i < 1000){
    if(n >= i & n < i + 100){
        pos = (i + 1) / 100;     
    }
    i+= 100;
}

if(pos == 10) pos = pos - 1;
Console.WriteLine(pos);