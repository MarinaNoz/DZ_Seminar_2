Console.WriteLine("Введите число, соответсвующее дню недели ");
int Number = Convert.ToInt32(Console.ReadLine());
int [] Weekday = {1, 2, 3, 4, 5, 6, 7 };

if (Number < Weekday[5]) 
{
    Console.WriteLine ("Нет,рабочий день ");
}
else if (Number < 0 || Number > 7 )
{
   Console.WriteLine("Некорректные данные  ");
}
else 
{
    Console.WriteLine("Да, выходной день ");
}








