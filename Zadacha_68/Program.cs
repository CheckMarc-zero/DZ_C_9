
int m = insertNumber("Введите m:");
int n = insertNumber("Введите n:");


if (n<0 || m<0) Console.WriteLine("Данные введены неправильно.");
else 
{
    Console.WriteLine($"Значение функции Аккермана : {RecFunc(m,n)} ");
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
    if (m==0 && n>0) return n+1;
    else if (m>0 && n==0) return  RecFunc(m-1,1);
    else if (m>0 && n>0) return  RecFunc(m-1,RecFunc(m,n-1));
    else return 0;
}
