
int n = insertNumber("Введите нижнюю границу промежутка:");
int m = insertNumber("Введите верхнюю границу промежутка:");


if (n>m) Console.WriteLine("Данные введены неправильно.");
else 
{
    Console.WriteLine($"Сумма чисел в данном промежутке : {RecFunc(m,n)} ");
}



//Метод ввода данных
int insertNumber (string message)
{
    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод с рекурсией
int RecFunc(int m, int n)
{
    if (m==n) return n;
    else return m + RecFunc(m-1,n);
}
