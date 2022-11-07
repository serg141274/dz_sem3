/*Напишите программу, которая принимает на вход пятизначное число,
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

void Palindrom(int number)
{
    if( number >=10000)
    {
      int firstnum1 = number / 10000;
      int lastnum1 = number % 10;
      if (firstnum1 == lastnum1 )
    {
    number=number/10;
     int firstnum2 = (number / 100)%10;
      int lastnum2 = number % 10;
      if (firstnum2 == lastnum2 )
      Console.WriteLine("Да");
    }
    else
    Console.WriteLine("Нет");
    }
}
 Console.WriteLine("Введите пятизначное число");
 int number=Convert.ToInt32(Console.ReadLine());
 Palindrom( number);*/
////////////////////////////////////////////////////////
/*Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 3D пространстве.
A(3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/*void Distance(  double x1, double y1, double z1, double x2, double y2,
double z2)
{
    double dist=Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
Console.WriteLine($"длинна отрезка={dist}");
return;                             
}
Console.WriteLine("input x1");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y1");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input z1");
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input x2");
double x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y2");
double y2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input z2");
double z2=Convert.ToDouble(Console.ReadLine());
Distance(x1,y1,z1,x2,y2,z2);*/