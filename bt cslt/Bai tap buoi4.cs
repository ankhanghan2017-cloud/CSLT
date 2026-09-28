/*using System;

class Program
{
    static void bai1()
    {
        Console.WriteLine("Nhap do tuoi");
        int tuoi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap gio:");
        int gio = Convert.ToInt32(Console.ReadLine());
        if (tuoi > 60 || tuoi < 12)
        {
            int gia = 50000;
            Console.WriteLine("Gia ve: " + gia);
        }
        else if (gio >= 17)
        {
            int gia = 110000;
            Console.WriteLine("Gia ve: " + gia);
        }
        else
        {
            int gia = 80000;
            Console.WriteLine("Gia ve: " + gia);
        }
    }
    static void bai2()
    {
        Console.WriteLine("Quyen he thong:");
        string quyen = Console.ReadLine();
        switch (quyen)
        {
            case "ADMIN":
                Console.WriteLine("Toàn quyền quản trị hệ thống.");
                break;
            case "MANAGER":
                Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo.");
                break;
            case "GUEST":
                Console.WriteLine("Chỉ có quyền xem thông tin công khai.");
                break;
            case "EMPLOYEE":
                Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                break;
            default:
                Console.WriteLine("Mã vai trò không hợp lệ!");
                break;
        }
    }
    static void bai3()
    {
        Console.WriteLine("Nhap so du tai khoan:");
        int soDu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so tien muon rut:");
        int soTienRut = Convert.ToInt32(Console.ReadLine());
        if (soTienRut <= 0)
        {
            Console.WriteLine("Số tiền rút phải lớn hơn 0.");
        }
        else if (soTienRut > soDu)
        {
            Console.WriteLine("Số dư không đủ để rút tiền.");
        }
        else if (soTienRut > 5000000)
        {
            Console.WriteLine("Số tiền rút vượt quá giới hạn 5,000,000 VNĐ.");
        }
        else if (soTienRut % 50000 != 0)
        {
            Console.WriteLine("Số tiền rút phải là bội số của 50,000 VNĐ.");
        }
        else
        {
            soDu -= soTienRut;
            Console.WriteLine("Giao dịch thành công. Số dư còn lại: " + soDu + " VNĐ");
        }
    }
    static void bai4()
    {
        Console.WriteLine("Nhap so tu 0 den 4:");
        int so = Convert.ToInt32(Console.ReadLine());
        switch (so)
        {
            case 1:
                Console.WriteLine("[Tổng đài]: Gặp tổng đài viên tư vấn thẻ.");
                break;
            case 2:
                Console.WriteLine("[Tổng đài]: Tra cứu số dư tài khoản.");
                break;
            case 3:
                Console.WriteLine("[Tổng đài]: Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận.");
                break;
            case 4:
                Console.WriteLine("[Tổng đài]: Tra cứu tỷ giá ngoại tệ.");
                break;
            case 0:
                Console.WriteLine("[Tổng đài]: Quay lại menu chính.");
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                break;
        }
    }
    static void bai5()
    {
        Console.WriteLine("Nhap so km di chuyen:");
        double km = Convert.ToDouble(Console.ReadLine());
        double tongTien = 0;

        if (km <= 1)
        {
            tongTien = 15000;
        }
        else if (km <= 10)
        {
            tongTien = 15000 + (km - 1) * 12000;
        }
        else
        {
            tongTien = 15000 + 9 * 12000 + (km - 10) * 10000;
        }

        Console.WriteLine("Tổng tiền trước giảm: " + tongTien + " VNĐ");
        if (km > 30)
        {
            double giam = tongTien * 0.1;
            double thanhTien = tongTien - giam;
            Console.WriteLine("Khuyến mãi (10%): -" + giam + " VNĐ");
            Console.WriteLine("Thành tiền: " + thanhTien + " VNĐ");
        }
        else
        {
            Console.WriteLine("Thành tiền: " + tongTien + " VNĐ");
        }
    }
    static void bai6()
    {
        Console.WriteLine("Nhap ma trang thai don hang (1-5):");
        int trangThai = Convert.ToInt32(Console.ReadLine());
        switch (trangThai)
        {
            case 1:
                Console.WriteLine("[Trạng thái]: Chờ xác nhận thanh toán.");
                break;
            case 2:
                Console.WriteLine("[Trạng thái]: Đang đóng gói và bàn giao đơn vị vận chuyển.");
                break;
            case 3:
                Console.WriteLine("[Trạng thái]: Đơn hàng đang trên đường giao đến bạn.");
                break;
            case 4:
                Console.WriteLine("[Trạng thái]: Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                break;
            case 5:
                Console.WriteLine("[Trạng thái]: Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                break;
            default:
                Console.WriteLine("Mã trạng thái không hợp lệ.");
                break;
        }
    }
    static void bai7()
    {
        Console.WriteLine("Nhap chieu cao (m):");
        double chieuCao = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap can nang (kg):");
        double canNang = Convert.ToDouble(Console.ReadLine());

        double bmi = canNang / (chieuCao * chieuCao);
        string danhGia = "";

        if (bmi < 18.5)
        {
            danhGia = "Thầy gầy - Nên bổ sung dinh dưỡng.";
        }
        else if (bmi < 25)
        {
            danhGia = "Cân đối - Tiếp tục duy trì.";
        }
        else if (bmi < 30)
        {
            danhGia = "Thừa cân - Nên tăng cường luyện tập.";
        }
        else
        {
            danhGia = "Béo phì - Cần sự tư vấn từ bác sĩ.";
        }

        Console.WriteLine("BMI: " + Math.Round(bmi, 2) + " - Đánh giá: " + danhGia);
    }
    static void bai8()
    {
        Console.WriteLine("Nhap loai xe (BIKE hoac CAR):");
        string loaiXe = Console.ReadLine();
        Console.WriteLine("Nhap thoi gian gui (1: Ban ngay, 2: Ban dem):");
        int thoiGian = Convert.ToInt32(Console.ReadLine());

        switch (loaiXe)
        {
            case "BIKE":
                if (thoiGian == 1)
                {
                    Console.WriteLine("Phí gửi xe Máy (Ban ngày): 5,000 VNĐ");
                }
                else if (thoiGian == 2)
                {
                    Console.WriteLine("Phí gửi xe Máy (Ban đêm): 10,000 VNĐ");
                }
                else
                {
                    Console.WriteLine("Thời gian không hợp lệ.");
                }
                break;
            case "CAR":
                if (thoiGian == 1)
                {
                    Console.WriteLine("Phí gửi xe Ô tô (Ban ngày): 30,000 VNĐ");
                }
                else if (thoiGian == 2)
                {
                    Console.WriteLine("Phí gửi xe Ô tô (Ban đêm): 60,000 VNĐ");
                }
                else
                {
                    Console.WriteLine("Thời gian không hợp lệ.");
                }
                break;
            default:
                Console.WriteLine("Loại xe không hợp lệ.");
                break;
        }
    }
    static void bai9()
    {
        Console.WriteLine("Nhap GPA (he 4.0):");
        double gpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap DRL (he 100):");
        int drl = Convert.ToInt32(Console.ReadLine());

        if (gpa >= 3.6 && drl >= 90)
        {
            Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%)");
        }
        else if (gpa >= 3.2 && drl >= 80)
        {
            if (gpa >= 3.6 && drl < 90)
            {
                Console.WriteLine("Kết quả: Học bổng Khá/Giỏi (Mức 50%) (Do DRL < 90)");
            }
            else
            {
                Console.WriteLine("Kết quả: Học bổng Khá/Giỏi (Mức 50%)");
            }
        }
        else
        {
            Console.WriteLine("Kết quả: Không đạt học bổng.");
        }
    }
    static void bai10()
    {
        Console.WriteLine("Nhap so tien (VND):");
        double soTien = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap ma ngoai te (USD, EUR, JPY):");
        string ma = Console.ReadLine();

        switch (ma)
        {
            case "USD":
                double usd = soTien / 25400;
                Console.WriteLine("Số tiền sau quy đổi: " + usd.ToString("F2") + " USD");
                break;
            case "EUR":
                double eur = soTien / 27200;
                Console.WriteLine("Số tiền sau quy đổi: " + eur.ToString("F2") + " EUR");
                break;
            case "JPY":
                double jpy = soTien / 165;
                Console.WriteLine("Số tiền sau quy đổi: " + jpy.ToString("F2") + " JPY");
                break;
            default:
                Console.WriteLine("Mã ngoại tệ không hợp lệ.");
                break;
        }
    }
    static void Main(string[] args)
    {
        bai1();
    }
}*/