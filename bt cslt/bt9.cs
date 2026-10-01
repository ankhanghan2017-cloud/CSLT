using System;
using System.Collections.Generic;

namespace CSLT
{
    class Program
    {
        #region 1. Input a string and print it
        // 1. Nhap mot chuoi va in ra man hinh
        static void Bai1()
        {
            Console.WriteLine("\n--- 1. NHAP VA IN CHUOI ---");
            Console.Write("Nhap mot chuoi bat ky: ");
            string str = Console.ReadLine() ?? "";
            Console.WriteLine($"Chuoi ban vua nhap: \"{str}\"");
        }
        #endregion

        #region 2. Find length of string without library function
        // 2. Tim do dai chuoi ma KHONG dung ham thu vien (khong dung .Length)
        static int GetStringLengthCustom(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                count++;
            }
            return count;
        }

        static void Bai2()
        {
            Console.WriteLine("\n--- 2. TIM DO DAI CHUOI (KHONG DUNG HAM THU VIEN) ---");
            Console.Write("Nhap chuoi can dem do dai: ");
            string str = Console.ReadLine() ?? "";
            int len = GetStringLengthCustom(str);
            Console.WriteLine($"Do dai cua chuoi (tinh bang vong lap foreach): {len} ky tu");
        }
        #endregion

        #region 3. Separate individual characters from a string
        // 3. Tach va in cac ky tu rieng le trong chuoi
        static void Bai3()
        {
            Console.WriteLine("\n--- 3. TACH CAC KY TU RIENG LE TRONG CHUOI ---");
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine() ?? "";
            Console.Write("Cac ky tu rieng le cach nhau boi khoang trang: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region 4. Print individual characters of string in reverse order
        // 4. In cac ky tu cua chuoi theo thu tu dao nguoc
        static void Bai4()
        {
            Console.WriteLine("\n--- 4. IN CAC KY TU THEO THU TU DAO NGUOC ---");
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine() ?? "";
            Console.Write("Cac ky tu theo thu tu dao nguoc: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region 5. Count total number of words in a string
        // 5. Dem tong so tu trong chuoi
        static int CountWords(string str)
        {
            int count = 0;
            bool inWord = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return count;
        }

        static void Bai5()
        {
            Console.WriteLine("\n--- 5. DEM TONG SO TU TRONG CHUOI ---");
            Console.Write("Nhap chuoi van ban: ");
            string str = Console.ReadLine() ?? "";
            int totalWords = CountWords(str);
            Console.WriteLine($"Tong so tu trong chuoi: {totalWords} tu");
        }
        #endregion

        #region 6. Compare two strings without using library functions
        // 6. So sanh 2 chuoi KHONG dung ham thu vien (khong dung String.Compare, Equals, ==)
        static int CompareStringsCustom(string s1, string s2)
        {
            int len1 = GetStringLengthCustom(s1);
            int len2 = GetStringLengthCustom(s2);
            int minLen = len1 < len2 ? len1 : len2;

            for (int i = 0; i < minLen; i++)
            {
                if (s1[i] != s2[i])
                {
                    return s1[i] - s2[i]; // < 0 neu s1 < s2, > 0 neu s1 > s2
                }
            }
            return len1 - len2;
        }

        static void Bai6()
        {
            Console.WriteLine("\n--- 6. SO SANH HAI CHUOI (KHONG DUNG HAM THU VIEN) ---");
            Console.Write("Nhap chuoi thu nhat (s1): ");
            string s1 = Console.ReadLine() ?? "";
            Console.Write("Nhap chuoi thu hai (s2): ");
            string s2 = Console.ReadLine() ?? "";

            int result = CompareStringsCustom(s1, s2);
            if (result == 0)
            {
                Console.WriteLine("=> Hai chuoi HOAN TOAN BANG NHAU (s1 == s2).");
            }
            else if (result < 0)
            {
                Console.WriteLine($"=> Chuoi s1 nho hon chuoi s2 theo thu tu ma ASCII (do lech: {result}).");
            }
            else
            {
                Console.WriteLine($"=> Chuoi s1 lon hon chuoi s2 theo thu tu ma ASCII (do lech: +{result}).");
            }
        }
        #endregion

        #region 7. Count alphabets, digits and special characters
        // 7. Dem so luong chu cai, chu so va ky tu dac biet
        static void Bai7()
        {
            Console.WriteLine("\n--- 7. DEM CHU CAI, CHU SO VA KY TU DAC BIET ---");
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine() ?? "";

            int alphabets = 0, digits = 0, specialChars = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    alphabets++;
                }
                else if (c >= '0' && c <= '9')
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }

            Console.WriteLine($" - So chu cai (Alphabets)           : {alphabets}");
            Console.WriteLine($" - So chu so (Digits)               : {digits}");
            Console.WriteLine($" - So ky tu dac biet (Special chars): {specialChars}");
        }
        #endregion

        #region 8. Count vowels or consonants
        // 8. Dem so luong nguyen am va phu am trong chuoi
        static void Bai8()
        {
            Console.WriteLine("\n--- 8. DEM NGUYEN AM VA PHU AM TRONG CHUOI ---");
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine() ?? "";

            int vowels = 0, consonants = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = char.ToLower(str[i]);
                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine($" - So luong nguyen am (Vowels) : {vowels}");
            Console.WriteLine($" - So luong phu am (Consonants): {consonants}");
        }
        #endregion

        #region 9. Check whether a given substring is present
        // 9. Kiem tra xem chuoi con co ton tai trong chuoi hay khong
        static bool CheckSubstringPresent(string str, string sub)
        {
            if (string.IsNullOrEmpty(sub)) return true;
            if (sub.Length > str.Length) return false;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return true;
            }
            return false;
        }

        static void Bai9()
        {
            Console.WriteLine("\n--- 9. KIEM TRA CHUOI CON CO TON TAI KHONG ---");
            Console.Write("Nhap chuoi goc: ");
            string str = Console.ReadLine() ?? "";
            Console.Write("Nhap chuoi con can kiem tra: ");
            string sub = Console.ReadLine() ?? "";

            bool exists = CheckSubstringPresent(str, sub);
            if (exists)
            {
                Console.WriteLine($"=> Ket qua: Chuoi con \"{sub}\" CO ton tai trong chuoi goc.");
            }
            else
            {
                Console.WriteLine($"=> Ket qua: Chuoi con \"{sub}\" KHONG ton tai trong chuoi goc.");
            }
        }
        #endregion

        #region 10. Search position of substring
        // 10. Tim vi tri (index) xuat hien dau tien cua chuoi con trong chuoi
        static int FindSubstringIndexCustom(string str, string sub)
        {
            if (string.IsNullOrEmpty(sub)) return 0;
            if (sub.Length > str.Length) return -1;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i;
            }
            return -1;
        }

        static void Bai10()
        {
            Console.WriteLine("\n--- 10. TIM VI TRI CUA CHUOI CON TRONG CHUOI ---");
            Console.Write("Nhap chuoi goc: ");
            string str = Console.ReadLine() ?? "";
            Console.Write("Nhap chuoi con can tim vi tri: ");
            string sub = Console.ReadLine() ?? "";

            int pos = FindSubstringIndexCustom(str, sub);
            if (pos != -1)
            {
                Console.WriteLine($"=> Tim thay chuoi con \"{sub}\" tai vi tri index: {pos} (vi tri thu {pos + 1} trong chuoi).");
            }
            else
            {
                Console.WriteLine($"=> Khong tim thay chuoi con \"{sub}\" trong chuoi goc (index = -1).");
            }
        }
        #endregion

        #region 11. Check whether a character is alphabet and its case
        // 11. Kiem tra ky tu co phai chu cai khong; neu phai thi kiem tra hoa/thuong
        static void Bai11()
        {
            Console.WriteLine("\n--- 11. KIEM TRA KY TU CO PHAI CHU CAI & CHU HOA / CHU THUONG ---");
            Console.Write("Nhap mot ky tu: ");
            string input = Console.ReadLine() ?? "";

            if (input.Length == 0)
            {
                Console.WriteLine("Ban chua nhap ky tu nao!");
                return;
            }

            char c = input[0];
            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine($"=> Ky tu '{c}' LA chu cai va la CHU HOA (Uppercase).");
            }
            else if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine($"=> Ky tu '{c}' LA chu cai va la CHU THUONG (Lowercase).");
            }
            else
            {
                Console.WriteLine($"=> Ky tu '{c}' KHONG PHAI la chu cai.");
            }
        }
        #endregion

        #region 12. Count occurrences of substring
        // 12. Dem so lan xuat hien cua chuoi con trong chuoi
        static int CountSubstringOccurrences(string str, string sub)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(sub) || sub.Length > str.Length)
                return 0;

            int count = 0;
            int i = 0;
            while (i <= str.Length - sub.Length)
            {
                bool match = true;
                for (int j = 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    count++;
                    i += sub.Length; // Nhay qua do dai chuoi con de dem khong trung lap
                }
                else
                {
                    i++;
                }
            }
            return count;
        }

        static void Bai12()
        {
            Console.WriteLine("\n--- 12. DEM SO LAN XUAT HIEN CUA CHUOI CON ---");
            Console.Write("Nhap chuoi goc: ");
            string str = Console.ReadLine() ?? "";
            Console.Write("Nhap chuoi con can dem: ");
            string sub = Console.ReadLine() ?? "";

            int times = CountSubstringOccurrences(str, sub);
            Console.WriteLine($"=> Chuoi con \"{sub}\" xuat hien tong cong {times} lan trong chuoi goc.");
        }
        #endregion

        #region 13. Insert substring before the first occurrence of a string
        // 13. Chen chuoi con vao truoc vi tri xuat hien dau tien cua mot chuoi
        static string InsertBeforeFirstOccurrence(string original, string searchStr, string toInsert)
        {
            int index = FindSubstringIndexCustom(original, searchStr);
            if (index == -1)
            {
                Console.WriteLine($"=> Khong tim thay chuoi \"{searchStr}\" trong chuoi goc de chen!");
                return original;
            }

            // Ghep chuoi: phan truoc + toInsert + searchStr + phan sau
            string before = original.Substring(0, index);
            string after = original.Substring(index);
            return before + toInsert + after;
        }

        static void Bai13()
        {
            Console.WriteLine("\n--- 13. CHEN CHUOI CON VAO TRUOC VI TRI XUAT HIEN DAU TIEN ---");
            Console.Write("Nhap chuoi goc: ");
            string original = Console.ReadLine() ?? "";
            Console.Write("Nhap chuoi moc can tim (search string): ");
            string searchStr = Console.ReadLine() ?? "";
            Console.Write("Nhap chuoi muon chen vao phia truoc (string to insert): ");
            string toInsert = Console.ReadLine() ?? "";

            string result = InsertBeforeFirstOccurrence(original, searchStr, toInsert);
            Console.WriteLine($"=> Chuoi sau khi chen: \"{result}\"");
        }
        #endregion

        #region Chay toan bo bai mau (Demo All)
        static void DemoAll()
        {
            Console.WriteLine("\n=========================================================================");
            Console.WriteLine("                  CHAY THU TOAN BO 13 YEU CAU (DEMO)                     ");
            Console.WriteLine("=========================================================================");

            string sampleText = "The quick brown fox jumps over the lazy dog 123! Happy C# coding.";
            Console.WriteLine($"Chuoi mau: \"{sampleText}\"\n");

            // 1
            Console.WriteLine($"1. In chuoi: \"{sampleText}\"");

            // 2
            Console.WriteLine($"2. Do dai chuoi (khong dung library): {GetStringLengthCustom(sampleText)} ky tu");

            // 3
            Console.Write("3. Tach ky tu rieng le: ");
            for (int i = 0; i < Math.Min(sampleText.Length, 20); i++) Console.Write(sampleText[i] + " ");
            Console.WriteLine("...");

            // 4
            Console.Write("4. In nguoc ky tu: ");
            for (int i = sampleText.Length - 1; i >= sampleText.Length - 20; i--) Console.Write(sampleText[i] + " ");
            Console.WriteLine("...");

            // 5
            Console.WriteLine($"5. Tong so tu: {CountWords(sampleText)} tu");

            // 6
            string cmp1 = "Hello";
            string cmp2 = "Hello World";
            int cmpResult = CompareStringsCustom(cmp1, cmp2);
            Console.WriteLine($"6. So sanh \"{cmp1}\" va \"{cmp2}\": {(cmpResult == 0 ? "Bang nhau" : (cmpResult < 0 ? "s1 < s2" : "s1 > s2"))}");

            // 7
            int a = 0, d = 0, s = 0;
            foreach (char c in sampleText)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) a++;
                else if (c >= '0' && c <= '9') d++;
                else s++;
            }
            Console.WriteLine($"7. Chu cai: {a}, Chu so: {d}, Ky tu dac biet: {s}");

            // 8
            int vow = 0, cons = 0;
            foreach (char c in sampleText)
            {
                char lower = char.ToLower(c);
                if (lower >= 'a' && lower <= 'z')
                {
                    if ("aeiou".Contains(lower)) vow++;
                    else cons++;
                }
            }
            Console.WriteLine($"8. Nguyen am: {vow}, Phu am: {cons}");

            // 9
            Console.WriteLine($"9. Chuoi \"fox\" co xuat hien? {CheckSubstringPresent(sampleText, "fox")}");

            // 10
            Console.WriteLine($"10. Vi tri cua \"brown\": Index {FindSubstringIndexCustom(sampleText, "brown")}");

            // 11
            char testChar = 'G';
            Console.WriteLine($"11. Kiem tra ky tu '{testChar}': {(char.IsUpper(testChar) ? "Chu cai HOA" : "Chu cai thuong")}");

            // 12
            Console.WriteLine($"12. So lan xuat hien cua \"the\": {CountSubstringOccurrences(sampleText.ToLower(), "the")} lan");

            // 13
            string inserted = InsertBeforeFirstOccurrence(sampleText, "brown", "extremely ");
            Console.WriteLine($"13. Chen \"extremely \" truoc \"brown\": \"{inserted}\"");
            Console.WriteLine("=========================================================================\n");
        }
        #endregion

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=========================================================================");
                Console.WriteLine("                   BAI TAP CSLT: STRINGS (CHUOI KY TU)                   ");
                Console.WriteLine("=========================================================================");
                Console.WriteLine(" 1. Nhap va in mot chuoi");
                Console.WriteLine(" 2. Tim do dai chuoi (khong dung ham thu vien)");
                Console.WriteLine(" 3. Tach cac ky tu rieng le trong chuoi");
                Console.WriteLine(" 4. In cac ky tu theo thu tu dao nguoc");
                Console.WriteLine(" 5. Dem tong so tu trong chuoi");
                Console.WriteLine(" 6. So sanh 2 chuoi (khong dung ham thu vien)");
                Console.WriteLine(" 7. Dem so chu cai, chu so va ky tu dac biet");
                Console.WriteLine(" 8. Dem so luong nguyen am va phu am");
                Console.WriteLine(" 9. Kiem tra chuoi con co ton tai hay khong");
                Console.WriteLine("10. Tim vi tri (index) cua chuoi con");
                Console.WriteLine("11. Kiem tra ky tu co phai chu cai va kiem tra hoa/thuong");
                Console.WriteLine("12. Dem so lan xuat hien cua chuoi con");
                Console.WriteLine("13. Chen chuoi con vao truoc vi tri xuat hien dau tien");
                Console.WriteLine("14. Chay demo toan bo 13 chuc nang voi chuoi mau");
                Console.WriteLine(" 0. Thoat chuong trinh");
                Console.Write("Moi ban chon (0-14): ");

                string? choice = Console.ReadLine()?.Trim();
                switch (choice)
                {
                    case "1": Bai1(); break;
                    case "2": Bai2(); break;
                    case "3": Bai3(); break;
                    case "4": Bai4(); break;
                    case "5": Bai5(); break;
                    case "6": Bai6(); break;
                    case "7": Bai7(); break;
                    case "8": Bai8(); break;
                    case "9": Bai9(); break;
                    case "10": Bai10(); break;
                    case "11": Bai11(); break;
                    case "12": Bai12(); break;
                    case "13": Bai13(); break;
                    case "14": DemoAll(); break;
                    case "0":
                        Console.WriteLine("Ket thuc chuong trinh. Tam biet!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Vui long chon tu 0 den 14.");
                        break;
                }
            }
        }
    }
}
