Console.Write("Введите координату X(1): ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(1): ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X(2): ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(2): ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z(1): ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z(2): ");
double z2 = Convert.ToDouble(Console.ReadLine());
double s = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z1-z2) * (z1-z2));
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно {Math.Round(s, 2)}");










