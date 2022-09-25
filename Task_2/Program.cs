int[] a = { 3, 6, 8 };
int[] b = { 2, 1, -7 };
int x = b[0] - a[0];
int y = b[1] - a[1];
int z = b[2] - a[2];

Console.Write("Расстояние между двумя точками в пространстве = ");
Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2)+Math.Pow(z, 2));
Console.WriteLine(Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2)+Math.Pow(z, 2)));