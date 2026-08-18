using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b:");
        int b = Convert.ToInt32(Console.ReadLine());
        int BCNN = (a * b) / GCD(a, b);
        float UCLN = (a * b) / BCNN;
        Console.WriteLine("UCLN cua {0} va {1} la: {2}", a, b, UCLN);

    }
}