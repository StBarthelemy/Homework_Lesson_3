//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine ("Введите кординаты точки А");
int [] pointA = new int[3];
for (int i = 0; i < pointA.Length; i++ )
{
    pointA[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine ("Введите кординаты точки B");
int [] pointB = new int[3];
for (int i = 0; i < pointB.Length; i++ )
{
    pointB[i] = Convert.ToInt32(Console.ReadLine());
}

int pointC = (pointB[0]- pointA[0])*(pointB[0]- pointA[0]);
int pointD = (pointB[1] -pointA[1])*(pointB[1] -pointA[1]);
int pointE = (pointB[2] -pointA[2])*(pointB[2] -pointA[2]);

Double finish= Math.Sqrt(pointC+pointD+pointE);
Console.WriteLine(Math.Round(finish,3));