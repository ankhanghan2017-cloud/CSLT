/*using System;
class Program
{
    static void Tinhtong(int a, int b)
    {
        int tong = a + b;
    }
    static void chanle(int a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("a la so chan");
        }
        else
        {
            Console.WriteLine("a la so le");
        }
    }
    static void TimMax(int a, int b, int c)
    {
        int max = a;
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
    }
    static void TinhGiaiThua(int n)
    {
        int giaiThua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
    }
    static void DaoNguocChuoi(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        string reversedStr = new string(arr);
    }
    static void Kiemtranguyento(int n)
    {
        if (n < 2)
        {
            Console.WriteLine(n + " khong phai la so nguyen to");
            return;
        }
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(n + " khong phai la so nguyen to");
                return;
            }
        }
        Console.WriteLine(n + " la so nguyen to");
    }
    static void Fibonanci(int n)
    {
        int a = 0, b = 1, c;
        Console.Write(a + " " + b + " ");
        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
    static void TinhLuythua(int x, int n)
    {
        int luyThua = 1;
        for (int i = 0; i < n; i++)
        {
            luyThua = x * luyThua;
        }
    }
    static void bai1()
    {
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Tinhtong(a, b);
    }
    static void Tinhtrungbinhmang(int[] arr)
    {
        int tong = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            tong += arr[i];
        }
        double trungBinh = (double)tong / arr.Length;
    }
    static void giatrinhonhattrongmang(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
    }
    static void bai2()
    {
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        chanle(a);
    }
    static void bai3()
    {
        Console.WriteLine("Nhap so a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so c:");
        int c = Convert.ToInt32(Console.ReadLine());
        TimMax(a, b, c);
    }
    static void bai4()
    {
        Console.WriteLine("Nhap so n:");
        int n = Convert.ToInt32(Console.ReadLine());
        TinhGiaiThua(n);
    }
    static void bai5()
    {
        Console.WriteLine("Nhap chuoi:");
        string str = Console.ReadLine();
        DaoNguocChuoi(str);
    }
    static void bai6()
    {
        Console.WriteLine("Nhap so n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Kiemtranguyento(n);
    }
    static void bai7()
    {
        Console.WriteLine("Nhap so n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Fibonanci(n);
    }
    static void bai8()
    {
        Console.WriteLine("Nhap so x:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so n:");
        int n = Convert.ToInt32(Console.ReadLine());
        TinhLuythua(x, n);
    }
    static void bai9()
    {
        Console.WriteLine("Nhap so phan tu mang:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Nhap phan tu thu " + (i + 1) + ":");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Tinhtrungbinhmang(arr);
    }
    static void bai10()
    {
        Console.WriteLine("Nhap so phan tu mang:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Nhap phan tu thu " + (i + 1) + ":");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        giatrinhonhattrongmang(arr);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Chon bai tap (1-9):");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                bai1();
                break;
            case 2:
                bai2();
                break;
            case 3:
                bai3();
                break;
            case 4:
                bai4();
                break;
            case 5:
                bai5();
                break;
            case 6:
                bai6();
                break;
            case 7:
                bai7();
                break;
            case 8:
                bai8();
                break;
            case 9:
                bai9();
                break;
            case 10:
                bai10();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le.");
                break;
        }
    }
}*/