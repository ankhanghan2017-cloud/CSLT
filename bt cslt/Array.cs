/*using System;
using System.Collections.Generic;

namespace CSLT
{
    class Program
    {
        static readonly Random rand = new Random();

        #region PART 1: 1D Array Functions
        // Tao mang so nguyen ngau nhien
        static int[] CreateRandomArray(int size, int minValue = 1, int maxValue = 100)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(minValue, maxValue + 1);
            }
            return arr;
        }

        // In mang ra man hinh
        static void PrintArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("[] (Mang rong)");
                return;
            }
            Console.WriteLine("[ " + string.Join(", ", arr) + " ]");
        }

        // 1. Tinh gia tri trung binh cac phan tu trong mang
        static double CalculateAverage(int[] arr)
        {
            if (arr.Length == 0) return 0;
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }

        // 2. Kiem tra mang co chua gia tri cu the khong
        static bool ContainsValue(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return true;
            }
            return false;
        }

        // 3. Tim vi tri (index) dau tien cua phan tu trong mang (-1 neu khong co)
        static int FindIndex(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
        }

        // 4. Xoa mot phan tu cu the khoi mang (xoa vi tri dau tien tim thay)
        static int[] RemoveElement(int[] arr, int target)
        {
            int index = FindIndex(arr, target);
            if (index == -1)
            {
                Console.WriteLine($"   Gia tri {target} khong ton tai trong mang.");
                return (int[])arr.Clone();
            }

            int[] newArr = new int[arr.Length - 1];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index) continue;
                newArr[k++] = arr[i];
            }
            return newArr;
        }

        // 5. Tim gia tri lon nhat va nho nhat cua mang
        static void FindMinMax(int[] arr, out int min, out int max)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Mang rong khong the tim min/max");
            }
            min = arr[0];
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
        }

        // 6. Dao nguoc mang so nguyen
        static void ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        // 7. Tim cac gia tri trung lap trong mang
        static int[] FindDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !duplicates.Contains(arr[i]))
                    {
                        duplicates.Add(arr[i]);
                        break;
                    }
                }
            }
            return duplicates.ToArray();
        }

        // 8. Xoa cac phan tu trung lap khoi mang (chi giu lai gia tri duy nhat)
        static int[] RemoveDuplicates(int[] arr)
        {
            List<int> uniqueList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!uniqueList.Contains(arr[i]))
                {
                    uniqueList.Add(arr[i]);
                }
            }
            return uniqueList.ToArray();
        }
        #endregion

        #region PART 2: Bubble Sort & Linear Search
        // Bubble Sort: sap xep mang tang dan
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        // Linear Search: tim kiem tu trong cau bang thuat toan tim kiem tuyen tinh
        static int LinearSearchWord(string sentence, string searchWord)
        {
            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' };
            string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"\nCac tu trong cau ({words.Length} tu): [ {string.Join(" | ", words)} ]");

            for (int i = 0; i < words.Length; i++)
            {
                if (string.Equals(words[i], searchWord, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        static void RunPart2()
        {
            Console.WriteLine("\n--- PHAN 2: BUBBLE SORT & LINEAR SEARCH ---");
            
            // 1. Yeu cau 10 so nguyen tu nguoi dung va sap xep bang Bubble Sort
            Console.WriteLine("\n[1] Nhap 10 so nguyen va sap xep bang Bubble Sort:");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap so thu {i + 1}/10: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write($"Gia tri khong hop le! Vui long nhap lai so thu {i + 1}: ");
                }
            }

            Console.Write("\nMang ban dau: ");
            PrintArray(numbers);

            BubbleSort(numbers);

            Console.Write("Mang sau khi sap xep Bubble Sort (tang dan): ");
            PrintArray(numbers);

            // 2. Yeu cau nhap mot cau va mot tu, tim xem tu co xuat hien khong bang Linear Search
            Console.WriteLine("\n[2] Tim kiem tu trong cau bang Linear Search:");
            Console.Write("Nhap mot cau (phrase/sentence): ");
            string sentence = Console.ReadLine() ?? "";

            Console.Write("Nhap tu can tim: ");
            string word = Console.ReadLine() ?? "";

            int foundIndex = LinearSearchWord(sentence, word);
            if (foundIndex != -1)
            {
                Console.WriteLine($"=> KET QUA: Tu '{word}' CO xuat hien trong cau tai tu thu {foundIndex + 1} (index {foundIndex}).");
            }
            else
            {
                Console.WriteLine($"=> KET QUA: Tu '{word}' KHONG xuat hien trong cau.");
            }
        }
        #endregion

        #region PART 3: 2D Matrix Functions
        // Tao ma tran so nguyen N x M ngau nhien
        static int[,] CreateRandomMatrix(int n, int m, int minValue = 1, int maxValue = 99)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(minValue, maxValue + 1);
                }
            }
            return matrix;
        }

        // In ma tran
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        // In dong thu i (0-indexed)
        static void PrintRow(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            Console.Write($"Dong {rowIndex} (0-indexed): [ ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[rowIndex, j] + (j < cols - 1 ? ", " : " "));
            }
            Console.WriteLine("]");
        }

        // In cot thu j (0-indexed)
        static void PrintCol(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            Console.Write($"Cot {colIndex} (0-indexed): [ ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, colIndex] + (i < rows - 1 ? ", " : " "));
            }
            Console.WriteLine("]");
        }

        // Tim gia tri lon nhat trong ma tran
        static int FindMatrixMax(int[,] matrix, out int maxRow, out int maxCol)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int max = matrix[0, 0];
            maxRow = 0;
            maxCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            return max;
        }

        // Tim gia tri nho nhat tren dong i
        static int FindMinOfRow(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            int min = matrix[rowIndex, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[rowIndex, j] < min)
                {
                    min = matrix[rowIndex, j];
                }
            }
            return min;
        }

        // Tim gia tri nho nhat tren cot j
        static int FindMinOfCol(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            int min = matrix[0, colIndex];
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, colIndex] < min)
                {
                    min = matrix[i, colIndex];
                }
            }
            return min;
        }

        // Chuyen vi ma tran (Transpose matrix N x M -> M x N)
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }
            return transposed;
        }

        // In duong cheo chinh va duong cheo phu (danh cho ma tran vuong N x N)
        static void PrintDiagonals(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("Ma tran khong phai ma tran vuong (N != M), khong co duong cheo chinh/phu.");
                return;
            }

            Console.Write("Duong cheo chinh (Main diagonal): [ ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, i] + (i < rows - 1 ? ", " : " "));
            }
            Console.WriteLine("]");

            Console.Write("Duong cheo phu (Secondary diagonal): [ ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, rows - 1 - i] + (i < rows - 1 ? ", " : " "));
            }
            Console.WriteLine("]");
        }

        static void RunPart3()
        {
            Console.WriteLine("\n--- PHAN 3: MA TRAN SO NGUYEN (2D MATRIX) ---");
            Console.Write("Nhap so hang N: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("N phai la so nguyen duong! Nhap lai N: ");
            }

            Console.Write("Nhap so cot M: ");
            int m;
            while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.Write("M phai la so nguyen duong! Nhap lai M: ");
            }

            int[,] matrix = CreateRandomMatrix(n, m);
            Console.WriteLine($"\nMa tran ngau nhien {n}x{m}:");
            PrintMatrix(matrix);

            // In dong i va tim min dong i
            Console.Write($"\nNhap chi so dong i muon in (0 den {n - 1}): ");
            int rowIdx;
            if (int.TryParse(Console.ReadLine(), out rowIdx) && rowIdx >= 0 && rowIdx < n)
            {
                PrintRow(matrix, rowIdx);
                Console.WriteLine($"Gia tri nho nhat tren dong {rowIdx}: {FindMinOfRow(matrix, rowIdx)}");
            }
            else
            {
                Console.WriteLine("Chi so dong khong hop le!");
            }

            // In cot j va tim min cot j
            Console.Write($"\nNhap chi so cot j muon in (0 den {m - 1}): ");
            int colIdx;
            if (int.TryParse(Console.ReadLine(), out colIdx) && colIdx >= 0 && colIdx < m)
            {
                PrintCol(matrix, colIdx);
                Console.WriteLine($"Gia tri nho nhat tren cot {colIdx}: {FindMinOfCol(matrix, colIdx)}");
            }
            else
            {
                Console.WriteLine("Chi so cot khong hop le!");
            }

            // Tim Max cua ma tran
            int maxVal = FindMatrixMax(matrix, out int maxR, out int maxC);
            Console.WriteLine($"\nGia tri lon nhat trong ma tran: {maxVal} tai toa do [{maxR}, {maxC}]");

            // Chuyen vi ma tran
            Console.WriteLine($"\nMa tran chuyen vi ({m}x{n}):");
            int[,] transposed = TransposeMatrix(matrix);
            PrintMatrix(transposed);

            // In duong cheo chinh / phu
            Console.WriteLine("\nKiem tra duong cheo (Main / Secondary Diagonal):");
            PrintDiagonals(matrix);
        }
        #endregion

        #region PART 1 Demo Runner
        static void RunPart1()
        {
            Console.WriteLine("\n--- PHAN 1: THAO TAC TREN MANG 1 CHIEU (1D ARRAY) ---");
            Console.Write("Nhap so phan tu cua mang: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("So luong phai la so nguyen duong! Nhap lai: ");
            }

            int[] arr = CreateRandomArray(size, 1, 30);
            Console.Write("\nMang ngau nhien ban dau: ");
            PrintArray(arr);

            // 1. Average
            Console.WriteLine($"1. Gia tri trung binh cua mang: {CalculateAverage(arr):F2}");

            // 2. Contains
            Console.Write("2. Nhap gia tri can kiem tra ton tai: ");
            int testVal = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"   => Ket qua: Mang {(ContainsValue(arr, testVal) ? "CO" : "KHONG")} chua {testVal}");

            // 3. Find index
            Console.Write("3. Nhap gia tri can tim vi tri (index): ");
            int searchVal = int.Parse(Console.ReadLine() ?? "0");
            int idx = FindIndex(arr, searchVal);
            Console.WriteLine($"   => Ket qua: Vi tri index cua {searchVal} la: {(idx != -1 ? idx.ToString() : "Khong tim thay (-1)")}");

            // 4. Remove element
            Console.Write("4. Nhap gia tri can xoa khoi mang: ");
            int removeVal = int.Parse(Console.ReadLine() ?? "0");
            int[] afterRemove = RemoveElement(arr, removeVal);
            Console.Write("   => Mang sau khi xoa: ");
            PrintArray(afterRemove);

            // 5. Min & Max
            FindMinMax(arr, out int min, out int max);
            Console.WriteLine($"5. Gia tri nho nhat (Min): {min} | Gia tri lon nhat (Max): {max}");

            // 6. Reverse
            int[] reversed = (int[])arr.Clone();
            ReverseArray(reversed);
            Console.Write("6. Mang sau khi dao nguoc (Reverse): ");
            PrintArray(reversed);

            // 7. Find duplicates
            int[] duplicates = FindDuplicates(arr);
            Console.Write("7. Cac gia tri bi trung lap trong mang: ");
            PrintArray(duplicates);

            // 8. Remove duplicates
            int[] unique = RemoveDuplicates(arr);
            Console.Write("8. Mang sau khi loai bo cac phan tu trung lap: ");
            PrintArray(unique);
        }
        #endregion

        #region PART 4: Jagged Array Basics (Bai 1 & Bai 2)
        // Bai 1: Khoi tao va hien thi mang rang cua co san
        static void RunPart4_Bai1()
        {
            Console.WriteLine("\n--- BAI 1: KHOI TAO VA HIEN THI JAGGED ARRAY CO SAN ---");
            int[][] jaggedArr = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 4, 4 }
            };

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write($"Hang {i} ({jaggedArr[i].Length} phan tu): \t");
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j],4} ");
                }
                Console.WriteLine();
            }
        }

        // Bai 2: Jagged array so nguyen va cac chuc nang
        static bool IsPrimeNumber(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void RunPart4_Bai2()
        {
            Console.WriteLine("\n--- BAI 2: JAGGED ARRAY SO NGUYEN (RANDOM/NHAP TAY) ---");
            Console.Write("Nhap so hang (rows) cua Jagged Array: ");
            if (!int.TryParse(Console.ReadLine(), out int numRows) || numRows <= 0)
            {
                Console.WriteLine("So hang khong hop le!");
                return;
            }

            int[][] jaggedArr = new int[numRows][];
            Console.WriteLine("Chon che do nhap: 1. Random (1-99) | 2. Nhap tay tu ban phim");
            Console.Write("Chon (1 hoac 2): ");
            bool isRandom = Console.ReadLine() != "2";

            for (int i = 0; i < numRows; i++)
            {
                Console.Write($"Nhap so cot cho hang {i}: ");
                int cols = int.Parse(Console.ReadLine()!);
                jaggedArr[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    if (isRandom)
                    {
                        jaggedArr[i][j] = rand.Next(1, 100);
                    }
                    else
                    {
                        Console.Write($"Phan tu [{i}][{j}]: ");
                        jaggedArr[i][j] = int.Parse(Console.ReadLine()!);
                    }
                }
            }

            Console.WriteLine("\nDu lieu mang:");
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write($"Hang {i}: \t");
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j],4} ");
                }
                Console.WriteLine();
            }

            // 1. So lon nhat tung hang va toan mang
            int overallMax = int.MinValue;
            Console.WriteLine("\n1. So lon nhat cua tung hang va toan mang:");
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                if (jaggedArr[i].Length == 0) continue;
                int rowMax = jaggedArr[i][0];
                for (int j = 1; j < jaggedArr[i].Length; j++)
                {
                    if (jaggedArr[i][j] > rowMax) rowMax = jaggedArr[i][j];
                }
                Console.WriteLine($" - Hang {i}: Max = {rowMax}");
                if (rowMax > overallMax) overallMax = rowMax;
            }
            Console.WriteLine($" => Max toan bo mang = {overallMax}");

            // 2. Sap xep tang dan tung hang
            Console.WriteLine("\n2. Mang sau khi sap xep tang dan tung hang:");
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Array.Sort(jaggedArr[i]);
                Console.Write($"Hang {i}: \t");
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j],4} ");
                }
                Console.WriteLine();
            }

            // 3. Cac phan tu la so nguyen to
            Console.WriteLine("\n3. Cac phan tu la so nguyen to:");
            int countPrime = 0;
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    if (IsPrimeNumber(jaggedArr[i][j]))
                    {
                        Console.WriteLine($" - Gia tri {jaggedArr[i][j]} tai [Hang {i}, Cot {j}]");
                        countPrime++;
                    }
                }
            }
            if (countPrime == 0) Console.WriteLine("Khong co so nguyen to nao trong mang.");

            // 4. Tim vi tri cua mot so
            Console.Write("\n4. Nhap so can tim kiem vi tri: ");
            if (int.TryParse(Console.ReadLine(), out int target))
            {
                var foundList = new List<string>();
                for (int i = 0; i < jaggedArr.Length; i++)
                {
                    for (int j = 0; j < jaggedArr[i].Length; j++)
                    {
                        if (jaggedArr[i][j] == target) foundList.Add($"[{i}, {j}]");
                    }
                }
                if (foundList.Count > 0)
                {
                    Console.WriteLine($"So {target} xuat hien tai vi tri: {string.Join(", ", foundList)}");
                }
                else
                {
                    Console.WriteLine($"Khong tim thay so {target} trong mang.");
                }
            }
        }

        static void RunPart4()
        {
            RunPart4_Bai1();
            RunPart4_Bai2();
        }
        #endregion

        #region PART 5: Company X Working Groups (Bai 3)
        // Lop luu tru thanh vien cong ty X
        class CompanyMember
        {
            public string Id { get; set; }
            public string FullName { get; set; }
            public int CompletedTasks { get; set; }

            public CompanyMember(string id, string fullName, int completedTasks)
            {
                Id = id;
                FullName = fullName;
                CompletedTasks = completedTasks;
            }
        }

        static CompanyMember[][] CreateCompanyData()
        {
            CompanyMember[][] company = new CompanyMember[3][];
            company[0] = new CompanyMember[]
            {
                new CompanyMember("G1-01", "Nguyen Van An", 15),
                new CompanyMember("G1-02", "Tran Thi Bich", 22),
                new CompanyMember("G1-03", "Le Hoang Cuong", 18),
                new CompanyMember("G1-04", "Pham Minh Duc", 32),
                new CompanyMember("G1-05", "Hoang Thi En", 25)
            };
            company[1] = new CompanyMember[]
            {
                new CompanyMember("G2-01", "Doan Van Giang", 12),
                new CompanyMember("G2-02", "Vu Thi Hoa", 28),
                new CompanyMember("G2-03", "Bui Quang Khai", 35)
            };
            company[2] = new CompanyMember[]
            {
                new CompanyMember("G3-01", "Ngo Thanh Lam", 20),
                new CompanyMember("G3-02", "Dinh Van Manh", 14),
                new CompanyMember("G3-03", "Ta Thi Nga", 35),
                new CompanyMember("G3-04", "Phan Van Oanh", 19),
                new CompanyMember("G3-05", "Cao Xuan Phuc", 27),
                new CompanyMember("G3-06", "Duong My Quynh", 30)
            };
            return company;
        }

        static void RunPart5()
        {
            CompanyMember[][] company = CreateCompanyData();

            while (true)
            {
                Console.WriteLine("\n-------------------------------------------------------");
                Console.WriteLine("      MENU PART 5: QUAN LY 3 NHOM LAM VIEC CONG TY X    ");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1. In danh sach tat ca thanh vien theo tung nhom");
                Console.WriteLine("2. Tim kiem thong tin thanh vien theo ID");
                Console.WriteLine("3. In thanh vien co so luong cong viec hoan thanh cao nhat");
                Console.WriteLine("0. Quay lai");
                Console.Write("Chon (0-3): ");

                string? choice = Console.ReadLine();
                if (choice == "0") break;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n--- DANH SACH THANH VIEN CONG TY X ---");
                        for (int g = 0; g < company.Length; g++)
                        {
                            Console.WriteLine($"\n>> NHOM {g + 1} ({company[g].Length} thanh vien):");
                            Console.WriteLine(string.Format("{0,-8} | {1,-10} | {2,-22} | {3,-10}", "STT", "ID", "HO VA TEN", "TASKS"));
                            for (int m = 0; m < company[g].Length; m++)
                            {
                                var mem = company[g][m];
                                Console.WriteLine(string.Format("{0,-8} | {1,-10} | {2,-22} | {3,5}",
                                    $"{g + 1}.{m + 1}", mem.Id, mem.FullName, mem.CompletedTasks));
                            }
                        }
                        break;

                    case "2":
                        Console.Write("\nNhap ID can tim: ");
                        string? targetId = Console.ReadLine()?.Trim();
                        bool found = false;
                        for (int g = 0; g < company.Length; g++)
                        {
                            for (int m = 0; m < company[g].Length; m++)
                            {
                                var mem = company[g][m];
                                if (string.Equals(mem.Id, targetId, StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine($"Tim thay: Nhom {g + 1} | ID: {mem.Id} | Ten: {mem.FullName} | Tasks: {mem.CompletedTasks}");
                                    found = true;
                                    break;
                                }
                            }
                            if (found) break;
                        }
                        if (!found) Console.WriteLine($"Khong tim thay thanh vien co ID '{targetId}'.");
                        break;

                    case "3":
                        int maxTasks = -1;
                        for (int g = 0; g < company.Length; g++)
                        {
                            for (int m = 0; m < company[g].Length; m++)
                            {
                                if (company[g][m].CompletedTasks > maxTasks)
                                    maxTasks = company[g][m].CompletedTasks;
                            }
                        }
                        Console.WriteLine($"\nThanh vien co so tasks hoan thanh cao nhat ({maxTasks} tasks):");
                        for (int g = 0; g < company.Length; g++)
                        {
                            for (int m = 0; m < company[g].Length; m++)
                            {
                                if (company[g][m].CompletedTasks == maxTasks)
                                {
                                    Console.WriteLine($" - Nhom {g + 1}: {company[g][m].FullName} (ID: {company[g][m].Id})");
                                }
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n==============================================");
                Console.WriteLine("        BAI TAP CO SO LAP TRINH (CSLT)        ");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. Thao tac tren Mang 1 chieu (8 ham co ban)");
                Console.WriteLine("2. Bubble Sort (10 so) & Linear Search (tim tu)");
                Console.WriteLine("3. Ma tran 2 chieu (Matrix N x M)");
                Console.WriteLine("4. Mang rang cua (Jagged Array - Bai 1 & Bai 2)");
                Console.WriteLine("5. Quan ly 3 nhom cong ty X (Jagged Array - Bai 3)");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon bai (0-5): ");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RunPart1();
                        break;
                    case "2":
                        RunPart2();
                        break;
                    case "3":
                        RunPart3();
                        break;
                    case "4":
                        RunPart4();
                        break;
                    case "5":
                        RunPart5();
                        break;
                    case "0":
                        Console.WriteLine("Thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                        break;
                }
            }
        }
    }
}*/
