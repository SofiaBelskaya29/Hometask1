/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getUserValue(string message)
{
 Console.WriteLine(message);
 int result = int.Parse(Console.ReadLine());
 return result;
}

int x1 = getUserValue("Введите координату X первой точки: ");
int y1 = getUserValue("Введите координату Y первой точки: ");
int z1 = getUserValue("Введите координату Z первой точки: ");
int x2 = getUserValue("Введите координату X второй точки: ");
int y2 = getUserValue("Введите координату Y второй точки: ");
int z2 = getUserValue("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {length}");

