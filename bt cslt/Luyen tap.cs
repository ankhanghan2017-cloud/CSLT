/*using System;
using System.Runtime.CompilerServices;
class Program
{
    static int tinhtong(int a, int b)
    {
        int tong = a + b;
        return tong;
    }
    static void bubblesort(int[] arr)
    {
        int m = arr.Length;
        for (int i = 0; i < m - 1; i++)
        {
            for (int j = 0; j < m - 1 - i; j++)
            {
                if (arr[i + 1] < arr[i])
                {
                    int low = arr[i];
                    arr[i] = arr[i + 1];
                    low = arr[i + 1];
                }
            }
        }
    }
    static void trungbinharr(int[] arr)
    {
        int m = arr.Length;
        int tong = 0;
        for (int i = 0; i < m; i++)
        {
            tong = tong + arr[i];
        }
        double trungbinhtong = (double)tong / m;
        Console.WriteLine("Trung binh mang la: " + trungbinhtong);
    }
    static void bai1()
    {
        Console.WriteLine("Nhap so n");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Nhap so m");
        int m = int.Parse(Console.ReadLine()!);
        Console.WriteLine(tinhtong(n, m));
    }
    static void bai2()
    {
        Console.WriteLine("Nhap do dai mang:");
        int n = int.Parse(Console.ReadLine()!);
        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap so lieu cho mang{i}");
            mang[i] = int.Parse(Console.ReadLine()!);
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(mang[i]);
        }
        bubblesort(mang);
        Console.WriteLine("Mang sau khi sap xep:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(mang[i]);
        }
        trungbinharr(mang);
    }
    static void bai3()
    {
        Console.WriteLine("Nhap do dai hang:");
        int hang = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Nhap do dai cot:");
        int cot = int.Parse(Console.ReadLine()!);
        int[,] mang = new int[hang, cot];
        for (int i = 0; i < hang; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                Console.WriteLine("Nhap gia tri:");
                mang[i, j] = int.Parse(Console.ReadLine()!);
            }
        }
        for (int i = 0; i < hang; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                Console.Write(mang[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Chon bai:");
        int chonbai = int.Parse(Console.ReadLine()!);
        switch (chonbai)
        {
            case 1:
                bai1();
                break;
                return;
            case 2:
                bai2();
                break;
                return;
            case 3:
                bai3();
                break;
                return;
        }

    }
}*/