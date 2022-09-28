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
Palindrom();
