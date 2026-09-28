/*using System;

class Program
{
    static void bai1()
    {
        Console.WriteLine("Nhap so tien ban dau:");
        int soTien = Convert.ToInt32(Console.ReadLine());
        Random rand = new Random();

        while (soTien > 0)
        {
            Console.WriteLine("So tien hien tai cua ban: " + soTien);
            Console.WriteLine("Nhap so tien muon cuoc:");
            int tienCuoc = Convert.ToInt32(Console.ReadLine());

            if (tienCuoc <= 0 || tienCuoc > soTien)
            {
                Console.WriteLine("So tien cuoc khong hop le!");
                continue;
            }

            Console.WriteLine("Chon cua cuoc (1: Tai [11-17], 2: Xiu [4-10]):");
            int chon = Convert.ToInt32(Console.ReadLine());

            int d1 = rand.Next(1, 7);
            int d2 = rand.Next(1, 7);
            int d3 = rand.Next(1, 7);
            int tong = d1 + d2 + d3;

            Console.WriteLine("Ket qua 3 con xi ngau: " + d1 + " - " + d2 + " - " + d3);
            Console.WriteLine("Tong diem: " + tong);

            if (d1 == d2 && d2 == d3)
            {
                Console.WriteLine("3 con xi ngau giong nhau, nha cai thang!");
                soTien -= tienCuoc;
            }
            else if ((tong >= 11 && tong <= 17 && chon == 1) || (tong >= 4 && tong <= 10 && chon == 2))
            {
                Console.WriteLine("Ban da doan dung! Nhan duoc: " + tienCuoc);
                soTien += tienCuoc;
            }
            else
            {
                Console.WriteLine("Ban da doan sai! Mat: " + tienCuoc);
                soTien -= tienCuoc;
            }

            if (soTien <= 0)
            {
                Console.WriteLine("Ban da het tien. Tro choi ket thuc!");
                break;
            }

            Console.WriteLine("Ban co muon choi tiep khong? (1: Co, 0: Khong):");
            int tiep = Convert.ToInt32(Console.ReadLine());
            if (tiep == 0)
            {
                break;
            }
        }
        Console.WriteLine("Ket thuc game. So tien con lai: " + soTien);
    }

    static void bai2()
    {
        Console.WriteLine("Nhap so tien ban dau:");
        double soTien = Convert.ToDouble(Console.ReadLine());
        Random rand = new Random();

        while (soTien > 0)
        {
            Console.WriteLine("So tien hien co: " + soTien);
            Console.WriteLine("Nhap so tien dat cuoc:");
            double tienCuoc = Convert.ToDouble(Console.ReadLine());

            if (tienCuoc <= 0 || tienCuoc > soTien)
            {
                Console.WriteLine("So tien dat cuoc khong hop le!");
                continue;
            }

            Console.WriteLine("Chon cap do (1: De [9 lan], 2: Trung binh [6 lan], 3: Kho [4 lan]):");
            int capDo = Convert.ToInt32(Console.ReadLine());

            int soLan = 0;
            double heSoThuong = 0;

            if (capDo == 1)
            {
                soLan = 9;
                heSoThuong = 0.5;
            }
            else if (capDo == 2)
            {
                soLan = 6;
                heSoThuong = 1.0;
            }
            else if (capDo == 3)
            {
                soLan = 4;
                heSoThuong = 3.0;
            }
            else
            {
                Console.WriteLine("Cap do khong hop le!");
                continue;
            }

            int soMay = rand.Next(1, 101);
            bool thang = false;

            for (int i = 1; i <= soLan; i++)
            {
                Console.WriteLine("Lan doan thu " + i + "/" + soLan + ". Nhap so ban doan (1-100):");
                int soDoan = Convert.ToInt32(Console.ReadLine());

                if (soDoan == soMay)
                {
                    Console.WriteLine("Chuc mung! Ban da doan dung so " + soMay);
                    thang = true;
                    break;
                }
                else if (soDoan < soMay)
                {
                    Console.WriteLine("So ban doan nho hon so bi mat.");
                }
                else
                {
                    Console.WriteLine("So ban doan lon hon so bi mat.");
                }
            }

            if (thang)
            {
                double tienThang = tienCuoc * heSoThuong;
                soTien += tienThang;
                Console.WriteLine("Ban thang " + tienThang + ". So du hien tai: " + soTien);
            }
            else
            {
                soTien -= tienCuoc;
                Console.WriteLine("Ban da het luot! So bi mat la: " + soMay);
                Console.WriteLine("Ban bi tru " + tienCuoc + ". So du hien tai: " + soTien);
            }

            if (soTien <= 0)
            {
                Console.WriteLine("So tien con lai 0 dong. Tro choi ket thuc!");
                break;
            }

            Console.WriteLine("Ban co muon choi tiep khong? (1: Co, 0: Khong):");
            int tiep = Convert.ToInt32(Console.ReadLine());
            if (tiep == 0)
            {
                break;
            }
        }
        Console.WriteLine("Ket thuc tro choi. Tong so tien con lai: " + soTien);
    }

    static void bai6()
    {
        Console.WriteLine("Nhap so n:");
        int n = Convert.ToInt32(Console.ReadLine());
        double tong = 0.0;

        Console.Write("Day so: ");
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write(" + 1/" + i);
            }
            tong += 1.0 / i;
        }
        Console.WriteLine();
        Console.WriteLine("Tong cua " + n + " phan tu la: " + tong);
    }

    static void bai7()
    {
        Console.WriteLine("Nhap so bat dau:");
        int batDau = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so ket thuc:");
        int ketThuc = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Cac so hoan hao trong khoang tu " + batDau + " den " + ketThuc + " la:");
        for (int i = batDau; i <= ketThuc; i++)
        {
            if (i <= 1)
            {
                continue;
            }

            int tongUoc = 0;
            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    tongUoc += j;
                }
            }

            if (tongUoc == i)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Chon bai tap (1: Game xi ngau, 2: Game doan so, 6: Harmonic series, 7: So hoan hao):");
        int chon = Convert.ToInt32(Console.ReadLine());
        switch (chon)
        {
            case 1:
                bai1();
                break;
            case 2:
                bai2();
                break;
            case 6:
                bai6();
                break;
            case 7:
                bai7();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le.");
                break;
        }
    }
}*/
