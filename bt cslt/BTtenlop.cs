/*using System;

class Program
{
    static void bt1()
    {
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b:");
        int b = Convert.ToInt32(Console.ReadLine());
        int tong = a + b;
        int hieu = a - b;
        int tich = a * b;
        float thuong = (float)a / b;
        Console.WriteLine("Tong: " + tong);
        Console.WriteLine("Hieu: " + hieu);
        Console.WriteLine("Tich: " + tich);
        Console.WriteLine("Thuong: " + thuong);
    }
    static void bt2()
    {
        Console.WriteLine("Nhap so y:");
        int y = int.Parse(Console.ReadLine());
        double x = Math.Pow(y, 2) + 2 * y + 1;
        Console.WriteLine("Ket qua: " + x);
    }
    static void bt3()
    {
        Console.WriteLine("Nhap do dai:");
        double dai = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thoi gian:");
        double thoigian = double.Parse(Console.ReadLine());
        double km = dai / thoigian;
        Console.WriteLine("Van toc: " + km + " km/h");
        double mps = km / 3.6;
        Console.WriteLine("Van toc: " + mps + " m/s");
    }
    static void bt4()
    {
        Console.WriteLine("Nhap radius:");
        double radius = double.Parse(Console.ReadLine());
        double chuvi = 4.0 / 3 * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine("The tich: " + chuvi);
    }
    static void bt5()
    {
        Console.WriteLine("Nhap chu cai:");
        char c = Console.ReadLine()[0];
        if (char.IsDigit(c))
        {
            Console.WriteLine("la so");
        }
        else if (char.IsLetter(c))
        {
            Console.WriteLine(" la chu cai");
        }
        else
        {
            Console.WriteLine("la ky tu dac biet");
        }

    }
    static void Main(string[] args)
    {
        bt1();
        bt2();
        bt3();
        bt4();
        bt5();
    }
}*/