
int N = insertNumber("Введите значение N");
int a = 1;

if (N<1) Console.WriteLine("Данные введены неправильно.");
else 
{
    Console.WriteLine($"Числа от {N} до {a} :");
    Console.WriteLine(RecFunc(a,N));
}



//Метод ввода данных
int insertNumber (string message)
{
    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод с рекурсией
string RecFunc(int a, int N)
{
    if (a<=N) return RecFunc(a+1,N) + $"{a} ";
    else return string.Empty;
}