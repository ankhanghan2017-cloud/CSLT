using System;

class Program
{
    static void bai1()
    {
        Console.WriteLine("Nhap so dien cu:");
        int soDienCu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so dien moi:");
        int soDienMoi = Convert.ToInt32(Console.ReadLine());
        int soDienTieuThu = soDienMoi - soDienCu;
        float tienDien = soDienTieuThu * 2000;
        float tienDiensauthue = tienDien * 1.08f;
        Console.WriteLine("tien dien phai tra la: " + tienDiensauthue);
    }

    static void bai2()
    {
        Console.WriteLine("Nhap can nang:");
        float canNang = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Nhap chieu cao:");
        float chieuCao = Convert.ToSingle(Console.ReadLine());
        float BMI = canNang / (chieuCao * chieuCao);
        if (BMI < 18.5)
        {
            Console.WriteLine("Phan loai suc khoe: Ban gay");
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("Phan loai suc khoe: Ban binh thuong");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("Phan loai suc khoe: Ban thua can");
        }
        else
        {
            Console.WriteLine("Phan loai suc khoe: Ban beo phi");
        }
    }

    static void bai3()
    {
        float usd = 25.400f;
        float EUR = 27.200f;
        int JPY = 165;
        float GBP = 32.100f;
        Console.WriteLine("Nhap so tien VND:");
        int vnd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap loai tien can doi (USD, EUR, JPY, GBP):");
        string loaiTien = Console.ReadLine();
        decimal phidichvu = vnd * 0.05m;
        decimal sotienduocdoi = vnd * 0.995m;
        if (loaiTien == "USD")
        {
            decimal sotienUSD = sotienduocdoi / (decimal)usd;
            Console.WriteLine("So tien sau khi doi sang USD: " + sotienUSD);
        }
        else if (loaiTien == "EUR")
        {
            decimal sotienEUR = sotienduocdoi / (decimal)EUR;
            Console.WriteLine("So tien sau khi doi sang EUR: " + sotienEUR);
        }
        else if (loaiTien == "JPY")
        {
            decimal sotienJPY = sotienduocdoi / JPY;
            Console.WriteLine("So tien sau khi doi sang JPY: " + sotienJPY);
        }
        else if (loaiTien == "GBP")
        {
            decimal sotienGBP = sotienduocdoi / (decimal)GBP;
            Console.WriteLine("So tien sau khi doi sang GBP: " + sotienGBP);
        }
        else
        {
            Console.WriteLine("Loai tien khong hop le.");
        }
    }

    static void bai4()
    {
        Console.WriteLine("Nhap ngay thang nam sinh cua ban (dd/mm/yyyy):");
        string ngaySinh = Console.ReadLine();
        DateTime ngaySinhDate = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null);
        DateTime ngayHienTai = DateTime.Now;
        int tuoi = ngayHienTai.Year - ngaySinhDate.Year;
        Console.WriteLine("Tuoi cua ban la: " + tuoi);
        Console.WriteLine("Ban da song tong cong:");
        int soNgaySong = (ngayHienTai - ngaySinhDate).Days;
        Console.WriteLine(soNgaySong + " ngay");
        Console.WriteLine("Sinh nhat tiep theo cua ban con:");
        DateTime sinhNhatTiepTheo = new DateTime(ngayHienTai.Year, ngaySinhDate.Month, ngaySinhDate.Day);
        if (sinhNhatTiepTheo < ngayHienTai)
        {
            sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);
        }
        TimeSpan khoangCach = sinhNhatTiepTheo - ngayHienTai;
        Console.WriteLine(khoangCach.Days + " ngay");
    }

    static void bai5()
    {
        Console.WriteLine("Nhap so diem cua mon Toanroirac:");
        double diemToan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so tin chi:");
        int soTinChitoan = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so diem cua mon laptrinhC#:");
        double diemLapTrinh = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so tin chi:");
        int soTinChilaptrinh = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so diem cua mon tieng anh:");
        double diemTiengAnh = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so tin chi:");
        int soTinChitienganh = Convert.ToInt32(Console.ReadLine());
        float sodiemtrungbinh = (float)((diemToan * soTinChitoan + diemLapTrinh * soTinChilaptrinh + diemTiengAnh * soTinChitienganh) / (soTinChitoan + soTinChilaptrinh + soTinChitienganh));
        Console.WriteLine("Diem trung binh cua ban la: " + sodiemtrungbinh);
        if (sodiemtrungbinh >= 8.5)
        {
            Console.WriteLine("Xep loai: Gioi");
        }
        else if (sodiemtrungbinh >= 7.0 && sodiemtrungbinh < 8.5)
        {
            Console.WriteLine("Xep loai: Kha");
        }
        else if (sodiemtrungbinh >= 5.0 && sodiemtrungbinh < 7.0)
        {
            Console.WriteLine("Xep loai: Trung binh");
        }
        else if (sodiemtrungbinh >= 4 && sodiemtrungbinh < 5.5)
        {
            Console.WriteLine("Xep loai: Yeu");
        }
        else
        {
            Console.WriteLine("Xep loai: Kem");
        }
    }

    static void bai6()
    {
        Console.WriteLine("Nhap ho ten:");
        string hoTenTho = Console.ReadLine();
        string[] tuArr = hoTenTho.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < tuArr.Length; i++)
        {
            tuArr[i] = char.ToUpper(tuArr[i][0]) + tuArr[i].Substring(1).ToLower();
        }
        string hoTenChuanHoa = string.Join(" ", tuArr);
        string ho = tuArr[0];
        string ten = tuArr[tuArr.Length - 1];
        string tenDem = "";
        if (tuArr.Length > 2)
        {
            string[] demArr = new string[tuArr.Length - 2];
            Array.Copy(tuArr, 1, demArr, 0, tuArr.Length - 2);
            tenDem = string.Join(" ", demArr);
        }
        else if (tuArr.Length == 2)
        {
            tenDem = "";
        }
        string username = ten.ToLower() + "." + ho.ToLower();
        for (int i = 1; i < tuArr.Length - 1; i++)
        {
            username += tuArr[i].ToLower();
        }
        string email = username + "@company.edu.vn";
        Console.WriteLine("Ho ten chuan hoa: " + hoTenChuanHoa);
        Console.WriteLine("Ho: " + ho + " | Ten dem: " + tenDem + " | Ten: " + ten);
        Console.WriteLine("Username tao tu dong: " + username);
        Console.WriteLine("Email cap phat: " + email);
    }

    static void bai7()
    {
        Console.WriteLine("Nhap quang duong (km):");
        double quangDuong = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap muc tieu hao nhien lieu (L/100km):");
        double mucTieuHao = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia xang (VND/Lit):");
        decimal giaXang = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Nhap so nguoi di:");
        int soNguoi = Convert.ToInt32(Console.ReadLine());
        double tongNhienLieu = (quangDuong / 100) * mucTieuHao;
        decimal tongChiPhi = (decimal)tongNhienLieu * giaXang;
        decimal chiPhiMoiNguoi = (decimal)(Math.Ceiling((double)(tongChiPhi / soNguoi) / 1000) * 1000);
        Console.WriteLine("Tong nhien lieu tieu thu: " + tongNhienLieu + " Lit");
        Console.WriteLine("Tong chi phi xang dau: " + tongChiPhi + " VND");
        Console.WriteLine("Chi phi moi nguoi: " + chiPhiMoiNguoi + " VND");
    }

    static void bai8()
    {
        string otpHeThong = "839201";
        DateTime thoiDiemTao = DateTime.Now;
        Console.WriteLine("Nhap ma OTP nhan duoc:");
        string otpNhap = Console.ReadLine();
        Console.WriteLine("Nhap so giay da troi qua:");
        int soGiay = Convert.ToInt32(Console.ReadLine());
        if (otpNhap.Length != 6 || !int.TryParse(otpNhap, out _))
        {
            Console.WriteLine("Trang thai xac thuc: THAT BAI - Dinh dang ma OTP khong hop le.");
        }
        else if (soGiay > 300)
        {
            Console.WriteLine("Trang thai xac thuc: THAT BAI - Ma OTP da het han.");
        }
        else if (otpNhap != otpHeThong)
        {
            Console.WriteLine("Trang thai xac thuc: THAT BAI - Ma OTP khong chinh xac.");
        }
        else
        {
            Console.WriteLine("Trang thai xac thuc: THANH CONG - Giao dich da duoc phe duyet.");
        }
    }

    static void bai9()
    {
        Console.WriteLine("Nhap luong Gross (VND):");
        decimal gross = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Nhap so nguoi phu thuoc:");
        int soNguoiPhuThuoc = Convert.ToInt32(Console.ReadLine());
        decimal bhxh = gross * 0.08m;
        decimal bhyt = gross * 0.015m;
        decimal bhtn = gross * 0.01m;
        decimal tongBaoHiem = bhxh + bhyt + bhtn;
        decimal giamTruBanThan = 11000000m;
        decimal giamTruPhuThuoc = soNguoiPhuThuoc * 4400000m;
        decimal thuNhapChiuThue = gross - tongBaoHiem - giamTruBanThan - giamTruPhuThuoc;
        if (thuNhapChiuThue < 0)
        {
            thuNhapChiuThue = 0;
        }
        decimal thueTNCN = 0;
        if (thuNhapChiuThue <= 5000000m)
        {
            thueTNCN = thuNhapChiuThue * 0.05m;
        }
        else if (thuNhapChiuThue <= 10000000m)
        {
            thueTNCN = 5000000m * 0.05m + (thuNhapChiuThue - 5000000m) * 0.10m;
        }
        else if (thuNhapChiuThue <= 18000000m)
        {
            thueTNCN = 5000000m * 0.05m + 5000000m * 0.10m + (thuNhapChiuThue - 10000000m) * 0.15m;
        }
        else if (thuNhapChiuThue <= 32000000m)
        {
            thueTNCN = 5000000m * 0.05m + 5000000m * 0.10m + 8000000m * 0.15m + (thuNhapChiuThue - 18000000m) * 0.20m;
        }
        else if (thuNhapChiuThue <= 52000000m)
        {
            thueTNCN = 5000000m * 0.05m + 5000000m * 0.10m + 8000000m * 0.15m + 14000000m * 0.20m + (thuNhapChiuThue - 32000000m) * 0.25m;
        }
        else if (thuNhapChiuThue <= 80000000m)
        {
            thueTNCN = 5000000m * 0.05m + 5000000m * 0.10m + 8000000m * 0.15m + 14000000m * 0.20m + 20000000m * 0.25m + (thuNhapChiuThue - 52000000m) * 0.30m;
        }
        else
        {
            thueTNCN = 5000000m * 0.05m + 5000000m * 0.10m + 8000000m * 0.15m + 14000000m * 0.20m + 20000000m * 0.25m + 28000000m * 0.30m + (thuNhapChiuThue - 80000000m) * 0.35m;
        }
        decimal net = gross - tongBaoHiem - thueTNCN;
        Console.WriteLine("Giam tru Bao hiem (10.5%): " + tongBaoHiem + " VND");
        Console.WriteLine("Thu nhap chiu thue: " + thuNhapChiuThue + " VND");
        Console.WriteLine("Thue TNCN phai nop: " + thueTNCN + " VND");
        Console.WriteLine("LUONG NET THUC NHAN: " + net + " VND");
    }

    static void bai10()
    {
        Console.WriteLine("Nhap ma san pham:");
        string maSP = Console.ReadLine();
        Console.WriteLine("Nhap ten san pham:");
        string tenSP = Console.ReadLine();
        Console.WriteLine("Nhap so luong ton kho (de trong neu chua kiem ke):");
        string inputSL = Console.ReadLine();
        int? quantity = string.IsNullOrWhiteSpace(inputSL) ? (int?)null : Convert.ToInt32(inputSL);
        int minThreshold = 10;
        Console.WriteLine("Nhap ngay restock (dd/MM/yyyy, de trong neu chua co):");
        string inputNgay = Console.ReadLine();
        DateTime? restockDate = string.IsNullOrWhiteSpace(inputNgay) ? (DateTime?)null : DateTime.ParseExact(inputNgay, "dd/MM/yyyy", null);

        int soLuongHienThi = quantity ?? 0;
        string trangThaiKho = "";
        if (quantity == null || quantity == 0)
        {
            trangThaiKho = "OutOfStock (Het hang)";
        }
        else if (quantity < minThreshold)
        {
            trangThaiKho = "LowStock (Sap het hang)";
        }
        else
        {
            trangThaiKho = "InStock (Con hang)";
        }
        string duKienNhapHang = restockDate?.ToString("dd/MM/yyyy") ?? "Chua co lich nhap hang";

        Console.WriteLine("San pham: " + tenSP + " (Ma: " + maSP + ")");
        Console.WriteLine("So luong hien thi: " + soLuongHienThi);
        Console.WriteLine("Trang thai kho: " + trangThaiKho);
        Console.WriteLine("Du kien nhap hang: " + duKienNhapHang);
    }

    static void bai11()
    {
        Console.WriteLine("Nhap so tien gui ban dau P (VND):");
        decimal P = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Nhap lai suat nam r (%/nam):");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap ky han gui n (thang):");
        int n = Convert.ToInt32(Console.ReadLine());

        decimal tienLaiDon = P * (decimal)(r / 100) * ((decimal)n / 12.0m);
        double tongTienKepDouble = (double)P * Math.Pow(1 + (r / 100) / 12.0, n);
        decimal tienLaiKep = (decimal)tongTienKepDouble - P;
        decimal chenhLech = tienLaiKep - tienLaiDon;

        Console.WriteLine("Tong tien lai (Lai don): " + Math.Round(tienLaiDon) + " VND");
        Console.WriteLine("Tong tien lai (Lai kep): " + Math.Round(tienLaiKep) + " VND");
        Console.WriteLine("Loi nhuan chenh lech: " + Math.Round(chenhLech) + " VND (Lai kep toi uu hon)");
    }

    static void bai12()
    {
        Console.WriteLine("Nhap van ban goc:");
        string vanBanGoc = Console.ReadLine();
        Console.WriteLine("Nhap khoa dich chuyen k (1-25):");
        int k = Convert.ToInt32(Console.ReadLine());
        char[] encryptedArr = new char[vanBanGoc.Length];
        char[] decryptedArr = new char[vanBanGoc.Length];
        for (int i = 0; i < vanBanGoc.Length; i++)
        {
            char c = vanBanGoc[i];
            if (c >= 'A' && c <= 'Z')
            {
                encryptedArr[i] = (char)('A' + (c - 'A' + k) % 26);
            }
            else if (c >= 'a' && c <= 'z')
            {
                encryptedArr[i] = (char)('a' + (c - 'a' + k) % 26);
            }
            else
            {
                encryptedArr[i] = c;
            }
        }
        string vanBanMaHoa = new string(encryptedArr);
        for (int i = 0; i < vanBanMaHoa.Length; i++)
        {
            char c = vanBanMaHoa[i];
            if (c >= 'A' && c <= 'Z')
            {
                decryptedArr[i] = (char)('A' + (c - 'A' - k + 26) % 26);
            }
            else if (c >= 'a' && c <= 'z')
            {
                decryptedArr[i] = (char)('a' + (c - 'a' - k + 26) % 26);
            }
            else
            {
                decryptedArr[i] = c;
            }
        }
        string vanBanGiaiMa = new string(decryptedArr);
        Console.WriteLine("Van ban Ma hoa: " + vanBanMaHoa);
        Console.WriteLine("Van ban Giai ma: " + vanBanGiaiMa);
    }

    static void bai13()
    {
        Console.WriteLine("Nhap loai xe (1: Motorbike, 2: Car, 3: Truck):");
        int loaiXe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap gio vao (yyyy-MM-dd HH:mm):");
        DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null);
        Console.WriteLine("Nhap gio ra (yyyy-MM-dd HH:mm):");
        DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null);

        double tongGio = (checkOut - checkIn).TotalHours;
        int gioTinhPhi = (int)Math.Ceiling(tongGio);
        decimal phi2GioDau = 0;
        decimal phiGioTiepTheo = 0;
        decimal giaMoiGioTiepTheo = 0;

        if (loaiXe == 1)
        {
            phi2GioDau = 5000m;
            giaMoiGioTiepTheo = 2000m;
        }
        else if (loaiXe == 2)
        {
            phi2GioDau = 20000m;
            giaMoiGioTiepTheo = 10000m;
        }
        else
        {
            phi2GioDau = 50000m;
            giaMoiGioTiepTheo = 25000m;
        }

        if (gioTinhPhi <= 2)
        {
            phiGioTiepTheo = 0;
        }
        else
        {
            phiGioTiepTheo = (gioTinhPhi - 2) * giaMoiGioTiepTheo;
        }

        decimal phiQuaDem = 0;
        if (checkOut.Date > checkIn.Date)
        {
            phiQuaDem = 30000m;
        }

        decimal tongPhi = phi2GioDau + phiGioTiepTheo + phiQuaDem;
        Console.WriteLine("Tong thoi gian do: " + Math.Round(tongGio, 2) + " gio -> Tinh phi: " + gioTinhPhi + " gio");
        Console.WriteLine("Phi 2 gio dau: " + phi2GioDau + " VND");
        if (gioTinhPhi > 2)
        {
            Console.WriteLine("Phi " + (gioTinhPhi - 2) + " gio tiep theo: " + phiGioTiepTheo + " VND");
        }
        if (phiQuaDem > 0)
        {
            Console.WriteLine("Phu phi qua dem: " + phiQuaDem + " VND");
        }
        Console.WriteLine("TONG PHI DO XE: " + tongPhi + " VND");
    }

    static void bai14()
    {
        Console.WriteLine("Nhap chuoi so:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int giaTri))
        {
            Console.WriteLine("Kiem tra Parse: Thanh cong! Gia tri int = " + giaTri);
            string phuHopByte = (giaTri >= 0 && giaTri <= 255) ? "CO (Vua van trong dai 0-255)" : "KHONG";
            Console.WriteLine("Phu hop kieu byte: " + phuHopByte);

            int temp = Math.Abs(giaTri);
            int tongChuSo = 0;
            while (temp > 0)
            {
                tongChuSo += temp % 10;
                temp /= 10;
            }
            Console.WriteLine("Tong cac chu so: " + tongChuSo);

            try
            {
                checked
                {
                    int test = giaTri * 10000000;
                }
                Console.WriteLine("Kiem tra Tran so: An toan trong pham vi int32.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Kiem tra Tran so: Xay ra loi tran so (OverflowException)!");
            }
        }
        else
        {
            Console.WriteLine("Kiem tra Parse: That bai! Chuoi nhap khong phai so nguyen hop le.");
        }
    }

    static void bai15()
    {
        decimal giaGoc = 100000m;
        Console.WriteLine("Nhap loai khach hang (1: Child, 2: Student, 3: Adult, 4: Senior):");
        int loaiKH = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap ngay xem phim trong tuan (Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday):");
        string ngayXem = Console.ReadLine();
        Console.WriteLine("Co the sinh vien hop le khong (true/false):");
        bool theSV = Convert.ToBoolean(Console.ReadLine());

        decimal giamGia = 0;
        if (loaiKH == 1 || loaiKH == 4)
        {
            giamGia = giaGoc * 0.50m;
        }
        else if (loaiKH == 2 && theSV && (ngayXem == "Monday" || ngayXem == "Tuesday" || ngayXem == "Wednesday" || ngayXem == "Thursday"))
        {
            giamGia = giaGoc * 0.30m;
        }
        else if (loaiKH == 3 && ngayXem == "Wednesday")
        {
            giamGia = giaGoc * 0.20m;
        }

        decimal phuThuCuoiTuan = 0;
        if (ngayXem == "Friday" || ngayXem == "Saturday" || ngayXem == "Sunday")
        {
            phuThuCuoiTuan = 20000m;
        }

        decimal tongTienVe = giaGoc - giamGia + phuThuCuoiTuan;
        Console.WriteLine("Gia ve goc: " + giaGoc + " VND");
        Console.WriteLine("Giam gia: -" + giamGia + " VND");
        Console.WriteLine("Phu thu cuoi tuan: " + phuThuCuoiTuan + " VND");
        Console.WriteLine("TONG TIEN VE: " + tongTienVe + " VND");
    }

    static void Main(string[] args)
    {
        bai1();
        bai2();
        bai3();
        bai4();
        bai5();
        bai6();
        bai7();
        bai8();
        bai9();
        bai10();
        bai11();
        bai12();
        bai13();
        bai14();
        bai15();
    }
}