// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double LineLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double lineXLength = xB - xA;
    double lineYLength = yB - yA;
    double lineZLength = zB - zA;
    double result = Math.Sqrt(Math.Pow(lineXLength,2) + Math.Pow(lineYLength,2) + Math.Pow(lineZLength,2));
    
    return result;
}

int xA = ReadInt("Input coordinate X of 1st point");
int yA = ReadInt("Input coordinate Y of 1st point");
int zA = ReadInt("Input coordinate Z of 1st point");
int xB = ReadInt("Input coordinate X of 2nd point");
int yB = ReadInt("Input coordinate Y of 2nd point");
int zB = ReadInt("Input coordinate Z of 2nd point");

System.Console.Write($"Line length between 1st point and 2nd point is {LineLength(xA, yA, zA, xB, yB, zB):f2}");
