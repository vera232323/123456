// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Palindrom ()
{
Console.WriteLine("Введите пятизначное число");
int palifive = Convert.ToInt32(Console.ReadLine());
int a = palifive/10000;
int b = palifive/1000%10;
int c = palifive/100%10;
int d = palifive%100/10;
int e = palifive%10;
int f;
f = Convert.ToInt32(e.ToString() + d.ToString() + c.ToString()+b.ToString()+a.ToString());
if(palifive > 9999 && palifive <= 99999)
    if(palifive == f)
   {
        Console.WriteLine($"{palifive} - палиндром");
   }
   else
   {
       Console.WriteLine($"{palifive} - не палиндром");
   }
else
{Console.WriteLine("Число не подходит под параметры ввода!!!!");}
}

// Palindrom();


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void treede ()
{
Console.WriteLine("Введите координату точки А по оси X");
    int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Y");
    int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Z");
    int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Б по оси X");
    int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Б по оси Y");
    int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Б по оси Z");
    int bz = Convert.ToInt32(Console.ReadLine());
int x = ax-bx;
int y = ay-by;
int z = az-bz;
double length = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine($"Длина отрезка {length}");}
// treede ();

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void cubinez ()

{
  Console.WriteLine("Введите любое число:");
    int number  = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}
}

// Palindrom();
// treede ();
// cubinez ();