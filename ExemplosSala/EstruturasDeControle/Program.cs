//numbers divisible by 3 and 4
for(int i = 0; i <= 30; i++){
    if(i % 3 == 0){
        Console.WriteLine("Número " + i + " é dividivel por 3");
    }
    if(i % 4 == 0){
        Console.WriteLine("Número " + i + " é dividivel por 4");
    }
}

//fibonacci 

int fib1 = 0;
Console.WriteLine(fib1);
int fib2 = 1;
Console.WriteLine(fib2);
int fib3 = fib2 + fib1;
Console.WriteLine(fib3);

while(true){
    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib1 + fib2;
    if(fib3 >= 100) break;
    Console.WriteLine(fib3);
}