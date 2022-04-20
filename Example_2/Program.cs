// выводим третью цифру числа или сообщаем, что третьей цифры нет
Console.WriteLine("Введите число");
string x = Console.ReadLine();
int b = x.Length;
if (b < 3)
{
   Console.WriteLine("Третье число отсутствует"); 
}
else
{
    Console.WriteLine("Третья цифра " + x[2]);
}



