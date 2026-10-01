/*using System;
using System.Collections.Generic;

namespace CSLT
{
    // Lop dai dien cho thanh vien trong Bai 3
    public class Member
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public int CompletedTasks { get; set; }

        public Member(string id, string fullName, int completedTasks)
        {
            Id = id;
            FullName = fullName;
            CompletedTasks = completedTasks;
        }

        public override string ToString()
        {
            return $"ID: {Id,-8} | Ho va ten: {FullName,-22} | So task hoan thanh: {CompletedTasks,3}";
        }
    }

    class Program
    {
        static readonly Random rand = new Random();

        #region BAI 1: Khoi tao va hien thi Jagged Array mac dinh
        // 1. Create a jagged array and initialize it using the following values 
        //    for its rows and columns; Then, display it.
        //    1 1 1 1 1
        //    2 2
        //    3 3 3 3
        //    4 4
        static void RunBai1()
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("BAI 1: KHOI TAO VA HIEN THI JAGGED ARRAY CO SAN");
            Console.WriteLine("=======================================================");

            // Khoi tao mang rang cua (jagged array) theo dung de bai
            int[][] jaggedArr = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 4, 4 }
            };

            Console.WriteLine($"So hang cua mang: {jaggedArr.Length}\n");
            Console.WriteLine("Du lieu mang rang cua:");
            PrintJaggedArray(jaggedArr);
        }
        #endregion

        #region BAI 2: Jagged Array voi so nguyen (Random / Nhap tay & Cac thao tac)
        // 2. Create a Jagged Array with random integer numbers (or by user input) 
        //    by getting the number of rows and columns from the user and printing 
        //    the data in the array to the user. Then, create functions to implement:
        //    1. Print the biggest number of each row and the largest number of the whole array.
        //    2. Sort values ascending of each row.
        //    3. Print items of the array that are prime.
        //    4. Search and print all positions of a number (enter from the user).

        // Ham nhap so nguyen duong
        static int ReadPositiveInt(string prompt)
        {
            int val;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out val) && val > 0)
                {
                    return val;
                }
                Console.WriteLine("Gia tri khong hop le! Vui long nhap so nguyen duong (> 0).");
            }
        }

        // Kiem tra so nguyen to
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // In mang rang cua ra man hinh
        static void PrintJaggedArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Hang {i} ({arr[i].Length} phan tu): \t");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j],4} ");
                }
                Console.WriteLine();
            }
        }

        // 2.1: In so lon nhat cua tung hang va so lon nhat toan bo mang
        static void PrintMaxOfRowsAndArray(int[][] arr)
        {
            Console.WriteLine("\n--- 1. Tim so lon nhat cua tung hang va toan bo mang ---");
            int overallMax = int.MinValue;
            bool hasElements = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 0)
                {
                    Console.WriteLine($"Hang {i}: Hang rong, khong co phan tu.");
                    continue;
                }

                int rowMax = arr[i][0];
                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > rowMax)
                    {
                        rowMax = arr[i][j];
                    }
                }

                Console.WriteLine($"Hang {i}: So lon nhat = {rowMax}");

                if (!hasElements || rowMax > overallMax)
                {
                    overallMax = rowMax;
                    hasElements = true;
                }
            }

            if (hasElements)
            {
                Console.WriteLine($"=> So lon nhat cua TOAN BO mang rang cua: {overallMax}");
            }
            else
            {
                Console.WriteLine("Mang khong co phan tu nao.");
            }
        }

        // 2.2: Sap xep tang dan tung hang
        static void SortRowsAscending(int[][] arr)
        {
            Console.WriteLine("\n--- 2. Sap xep gia tri tang dan tren tung hang ---");
            for (int i = 0; i < arr.Length; i++)
            {
                // Su dung thuat toan Bubble Sort cho tung hang
                int len = arr[i].Length;
                for (int step = 0; step < len - 1; step++)
                {
                    for (int j = 0; j < len - 1 - step; j++)
                    {
                        if (arr[i][j] > arr[i][j + 1])
                        {
                            int temp = arr[i][j];
                            arr[i][j] = arr[i][j + 1];
                            arr[i][j + 1] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Mang sau khi sap xep tang dan tung hang:");
            PrintJaggedArray(arr);
        }

        // 2.3: In cac phan tu la so nguyen to trong mang
        static void PrintPrimeNumbers(int[][] arr)
        {
            Console.WriteLine("\n--- 3. Cac phan tu la so nguyen to trong mang ---");
            var primes = new List<(int value, int row, int col)>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (IsPrime(arr[i][j]))
                    {
                        primes.Add((arr[i][j], i, j));
                    }
                }
            }

            if (primes.Count == 0)
            {
                Console.WriteLine("Khong co so nguyen to nao trong mang.");
            }
            else
            {
                Console.WriteLine($"Tim thay {primes.Count} phan tu la so nguyen to:");
                foreach (var item in primes)
                {
                    Console.WriteLine($" - Gia tri {item.value,3} tai vi tri [Hang {item.row}, Cot {item.col}]");
                }
            }
        }

        // 2.4: Tim kiem va in tat ca vi tri cua mot so
        static void SearchNumberPositions(int[][] arr)
        {
            Console.WriteLine("\n--- 4. Tim kiem va in vi tri cua mot so trong mang ---");
            Console.Write("Nhap so can tim kiem: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Gia tri nhap vao khong phai so nguyen!");
                return;
            }

            var positions = new List<(int row, int col)>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == target)
                    {
                        positions.Add((i, j));
                    }
                }
            }

            if (positions.Count == 0)
            {
                Console.WriteLine($"Khong tim thay so {target} o bat ky vi tri nao trong mang.");
            }
            else
            {
                Console.WriteLine($"So {target} xuat hien {positions.Count} lan tai cac vi tri:");
                foreach (var pos in positions)
                {
                    Console.WriteLine($" -> [Hang {pos.row}, Cot {pos.col}]");
                }
            }
        }

        static void RunBai2()
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("BAI 2: JAGGED ARRAY SO NGUYEN & CAC CHUC NANG");
            Console.WriteLine("=======================================================");

            int numRows = ReadPositiveInt("Nhap so hang (rows) cua Jagged Array: ");
            int[][] jaggedArr = new int[numRows][];

            Console.WriteLine("\nChon phuong thuc tao du lieu:");
            Console.WriteLine("1. Sinh so ngau nhien (Random 1 - 99)");
            Console.WriteLine("2. Nhap tay tung phan tu tu ban phim");
            Console.Write("Chon (1 hoac 2): ");
            string? modeChoice = Console.ReadLine();
            bool isRandom = modeChoice != "2";

            for (int i = 0; i < numRows; i++)
            {
                int numCols = ReadPositiveInt($"Nhap so cot cho hang {i}: ");
                jaggedArr[i] = new int[numCols];

                for (int j = 0; j < numCols; j++)
                {
                    if (isRandom)
                    {
                        jaggedArr[i][j] = rand.Next(1, 100);
                    }
                    else
                    {
                        Console.Write($"Nhap phan tu [{i}][{j}]: ");
                        while (!int.TryParse(Console.ReadLine(), out jaggedArr[i][j]))
                        {
                            Console.Write($"Nhap lai phan tu [{i}][{j}] (so nguyen): ");
                        }
                    }
                }
            }

            Console.WriteLine("\n--- Du lieu mang vua tao ---");
            PrintJaggedArray(jaggedArr);

            // Thuc hien 4 yeu cau cua bai 2
            PrintMaxOfRowsAndArray(jaggedArr);
            SortRowsAscending(jaggedArr);
            PrintPrimeNumbers(jaggedArr);
            SearchNumberPositions(jaggedArr);
        }
        #endregion

        #region BAI 3 (***): Quan ly 3 nhom lam viec cong ty X
        // The X company has 3 working groups; 
        // group 1 has 5 members, group 2 has 3 members, and group 3 has 6 members. 
        // The data stored for each member has an ID number, full name, and completed tasks. 
        // An ID identifies each member.
        // 
        // Tasks:
        // 1. Initialize an array with pre-assigned values or values entered from the keyboard.
        // 2. Print a list of all members.
        // 3. Print the information on a member when the ID is known.
        // 4. Print the member with the highest number of completed tasks.
        // Menu-driven interface.

        // Khoi tao mang 3 nhom mac dinh
        static Member[][] CreateDefaultCompanyData()
        {
            Member[][] company = new Member[3][];

            // Nhom 1: 5 thanh vien
            company[0] = new Member[]
            {
                new Member("G1-01", "Nguyen Van An", 15),
                new Member("G1-02", "Tran Thi Bich", 22),
                new Member("G1-03", "Le Hoang Cuong", 18),
                new Member("G1-04", "Pham Minh Duc", 32),
                new Member("G1-05", "Hoang Thi En", 25)
            };

            // Nhom 2: 3 thanh vien
            company[1] = new Member[]
            {
                new Member("G2-01", "Doan Van Giang", 12),
                new Member("G2-02", "Vu Thi Hoa", 28),
                new Member("G2-03", "Bui Quang Khai", 35)
            };

            // Nhom 3: 6 thanh vien
            company[2] = new Member[]
            {
                new Member("G3-01", "Ngo Thanh Lam", 20),
                new Member("G3-02", "Dinh Van Manh", 14),
                new Member("G3-03", "Ta Thi Nga", 35),
                new Member("G3-04", "Phan Van Oanh", 19),
                new Member("G3-05", "Cao Xuan Phuc", 27),
                new Member("G3-06", "Duong My Quynh", 30)
            };

            return company;
        }

        // Nhap du lieu cong ty tu ban phim
        static Member[][] InputCompanyDataFromKeyboard()
        {
            int[] groupSizes = new int[] { 5, 3, 6 };
            Member[][] company = new Member[3][];

            for (int g = 0; g < 3; g++)
            {
                Console.WriteLine($"\n--- NHAP THONG TIN CHO NHOM {g + 1} ({groupSizes[g]} thanh vien) ---");
                company[g] = new Member[groupSizes[g]];

                for (int m = 0; m < groupSizes[g]; m++)
                {
                    Console.WriteLine($"\nThanh vien thu {m + 1}/{groupSizes[g]}:");
                    string id;
                    while (true)
                    {
                        Console.Write(" - Ma ID: ");
                        id = Console.ReadLine()?.Trim() ?? "";
                        if (!string.IsNullOrEmpty(id)) break;
                        Console.WriteLine("ID khong duoc de trong!");
                    }

                    string name;
                    while (true)
                    {
                        Console.Write(" - Ho va ten: ");
                        name = Console.ReadLine()?.Trim() ?? "";
                        if (!string.IsNullOrEmpty(name)) break;
                        Console.WriteLine("Ho ten khong duoc de trong!");
                    }

                    int tasks;
                    while (true)
                    {
                        Console.Write(" - So cong viec da hoan thanh: ");
                        if (int.TryParse(Console.ReadLine(), out tasks) && tasks >= 0) break;
                        Console.WriteLine("So task phai la so nguyen khong am (>= 0)!");
                    }

                    company[g][m] = new Member(id, name, tasks);
                }
            }

            return company;
        }

        // 3.2: In danh sach tat ca thanh vien theo nhom
        static void PrintAllMembers(Member[][] company)
        {
            if (company == null)
            {
                Console.WriteLine("Chua co du lieu! Vui long khoi tao truoc.");
                return;
            }

            Console.WriteLine("\n=========================================================================");
            Console.WriteLine("               DANH SACH THANH VIEN CONG TY X THEO NHOM                  ");
            Console.WriteLine("=========================================================================");

            int totalMembers = 0;
            for (int g = 0; g < company.Length; g++)
            {
                Console.WriteLine($"\n>>> NHOM {g + 1} (Co {company[g].Length} thanh vien):");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine(string.Format("{0,-8} | {1,-10} | {2,-25} | {3,-15}", "STT", "ID", "HO VA TEN", "TASKS HOAN THANH"));
                Console.WriteLine("-------------------------------------------------------------------------");

                for (int m = 0; m < company[g].Length; m++)
                {
                    var mem = company[g][m];
                    if (mem != null)
                    {
                        Console.WriteLine(string.Format("{0,-8} | {1,-10} | {2,-25} | {3,10}",
                            $"{g + 1}.{m + 1}", mem.Id, mem.FullName, mem.CompletedTasks));
                        totalMembers++;
                    }
                }
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.WriteLine($"=> Tong so thanh vien trong cong ty: {totalMembers}\n");
        }

        // 3.3: Tim kiem thanh vien theo ID
        static void SearchMemberById(Member[][] company)
        {
            if (company == null)
            {
                Console.WriteLine("Chua co du lieu! Vui long khoi tao truoc.");
                return;
            }

            Console.Write("\nNhap ma ID can tim kiem: ");
            string? searchId = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(searchId))
            {
                Console.WriteLine("ID tim kiem khong hop le.");
                return;
            }

            bool found = false;
            for (int g = 0; g < company.Length; g++)
            {
                for (int m = 0; m < company[g].Length; m++)
                {
                    var mem = company[g][m];
                    if (mem != null && string.Equals(mem.Id, searchId, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("\n>>> KET QUA TIM KIEM:");
                        Console.WriteLine($" - Nhom cong tac    : Nhom {g + 1}");
                        Console.WriteLine($" - Vi tri trong nhom: {m + 1}");
                        Console.WriteLine($" - Ma ID            : {mem.Id}");
                        Console.WriteLine($" - Ho va ten        : {mem.FullName}");
                        Console.WriteLine($" - Tasks hoan thanh : {mem.CompletedTasks}");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine($"Khong tim thay thanh vien nao co ID la '{searchId}'.");
            }
        }

        // 3.4: In thanh vien co so luong cong viec hoan thanh cao nhat
        static void PrintMemberWithHighestTasks(Member[][] company)
        {
            if (company == null)
            {
                Console.WriteLine("Chua co du lieu! Vui long khoi tao truoc.");
                return;
            }

            int maxTasks = -1;
            for (int g = 0; g < company.Length; g++)
            {
                for (int m = 0; m < company[g].Length; m++)
                {
                    var mem = company[g][m];
                    if (mem != null && mem.CompletedTasks > maxTasks)
                    {
                        maxTasks = mem.CompletedTasks;
                    }
                }
            }

            if (maxTasks == -1)
            {
                Console.WriteLine("Khong co du lieu thanh vien hop le.");
                return;
            }

            var topMembers = new List<(Member member, int group)>();
            for (int g = 0; g < company.Length; g++)
            {
                for (int m = 0; m < company[g].Length; m++)
                {
                    var mem = company[g][m];
                    if (mem != null && mem.CompletedTasks == maxTasks)
                    {
                        topMembers.Add((mem, g + 1));
                    }
                }
            }

            Console.WriteLine($"\n=======================================================");
            Console.WriteLine($"THANH VIEN CO SO TASK HOAN THANH CAO NHAT ({maxTasks} tasks)");
            Console.WriteLine($"=======================================================");
            foreach (var item in topMembers)
            {
                Console.WriteLine($" - Thuoc Nhom {item.group}: {item.member.FullName} (ID: {item.member.Id}) - {item.member.CompletedTasks} tasks");
            }
        }

        // Menu con cho Bai 3
        static void RunBai3()
        {
            Member[][]? company = null;

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------");
                Console.WriteLine("      MENU BAI 3: QUAN LY 3 NHOM LAM VIEC CONG TY X    ");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1. Khoi tao danh sach thanh vien (Gia tri mac dinh / Tu ban phim)");
                Console.WriteLine("2. In danh sach tat ca thanh vien theo nhom");
                Console.WriteLine("3. Tim kiem thong tin thanh vien theo ID");
                Console.WriteLine("4. In thanh vien co so luong cong viec hoan thanh cao nhat");
                Console.WriteLine("0. Quay lai menu chinh");
                Console.Write("Moi ban chon (0-4): ");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nChon cach khoi tao:");
                        Console.WriteLine(" a. Dung du lieu mau co san (14 thanh vien cua 3 nhom)");
                        Console.WriteLine(" b. Nhap tu ban phim cho tung thanh vien");
                        Console.Write("Chon (a/b): ");
                        string? initChoice = Console.ReadLine()?.Trim().ToLower();
                        if (initChoice == "b")
                        {
                            company = InputCompanyDataFromKeyboard();
                            Console.WriteLine("Da nhap xong du lieu tu ban phim!");
                        }
                        else
                        {
                            company = CreateDefaultCompanyData();
                            Console.WriteLine("Da khoi tao thanh cong du lieu mau cho 3 nhom (14 thanh vien)!");
                        }
                        break;
                    case "2":
                        if (company == null) company = CreateDefaultCompanyData();
                        PrintAllMembers(company);
                        break;
                    case "3":
                        if (company == null) company = CreateDefaultCompanyData();
                        SearchMemberById(company);
                        break;
                    case "4":
                        if (company == null) company = CreateDefaultCompanyData();
                        PrintMemberWithHighestTasks(company);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Vui long chon lai tu 0 den 4.");
                        break;
                }
            }
        }
        #endregion

        #region MAIN ENTRY POINT
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=======================================================");
                Console.WriteLine("        BAI TAP CSLT: JAGGED ARRAY (MANG RANG CUA)     ");
                Console.WriteLine("=======================================================");
                Console.WriteLine("1. Bai 1: Khoi tao va hien thi Jagged Array co san (1 1 1 1 1, ...)");
                Console.WriteLine("2. Bai 2: Jagged Array so nguyen (Random/Nhap tay, Max, Sort, SNT, Search)");
                Console.WriteLine("3. Bai 3: Quan ly 3 nhom lam viec cong ty X (Members Jagged Array)");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Moi ban chon bai (0-3): ");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RunBai1();
                        break;
                    case "2":
                        RunBai2();
                        break;
                    case "3":
                        RunBai3();
                        break;
                    case "0":
                        Console.WriteLine("Ket thuc chuong trinh. Tam biet!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai tu 0 den 3!");
                        break;
                }
            }
        }
        #endregion
    }
}*/
