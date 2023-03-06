Console.WriteLine("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1 > num_2)
 {
 Console.WriteLine("Первое число " + num_1 + " больше чем второе " + num_2);
 }
 else
{
Console.WriteLine("Второе число " + num_2 + " больше чем первое " + num_1);
}