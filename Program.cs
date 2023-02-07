//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Write("enter number: ");

int result = 0;

int number = Int32.Parse(Console.ReadLine());

int numberpal = number;
            
while (number > 0) 
 {
    result *= 10;
    result += number % 10;
    number /= 10;
}

if (result == numberpal)
{
    Console.WriteLine("Палиндром");
}
 else
      {
      Console.WriteLine("Не палиндром"); 
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("enter x1");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("enter y1");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("enter z1");
double numZ1 = double.Parse(Console.ReadLine());

Console.WriteLine("enter x2");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("enter y2");
double numY2 = double.Parse(Console.ReadLine());

Console.WriteLine("enter z2");
double numZ2 = double.Parse(Console.ReadLine());

double numSQRT = Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2);

double resultdist = Math.Sqrt(numSQRT);

Console.WriteLine(resultdist);

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("enter N");

int numN = int.Parse(Console.ReadLine());

double CubeN=1;

while (CubeN < numN)

{
 Console.WriteLine(Math.Pow(CubeN,3)+"");
 CubeN++;
}
