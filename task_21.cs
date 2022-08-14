// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = ReadInt("Введите X точки А: ");
int y1 = ReadInt("Введите Y точки А: ");
int z1 = ReadInt("Введите Z точки А: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");

    int lenghX = x1 + x2;
    int lenghY = y1 + y2;
    int lenghZ = z1 + z2;
    double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    
    
    string result = distance.ToString("#.##");
    Console.Write($"-> {result} ");

    int ReadInt(String message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }