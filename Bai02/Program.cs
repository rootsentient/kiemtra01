using System;
using System.Collections.Generic;

class Program
{
    // =========================================
    // CHỨC NĂNG 1: THÊM PHƯƠNG TIỆN
    // =========================================
    static void ThemPhuongTien(QuanLyPhuongTien quanLy)
    {
        try
        {
            Console.WriteLine("\n===== THÊM PHƯƠNG TIỆN =====");

            Console.Write("Nhập mã phương tiện: ");
            string ma = Console.ReadLine() ?? "";

            Console.Write("Nhập tên hãng: ");
            string tenHang = Console.ReadLine() ?? "";

            Console.Write("Nhập năm sản xuất: ");
            int nam = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập giá gốc: ");
            decimal gia = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("\n1. Ô tô");
            Console.WriteLine("2. Xe máy");

            Console.Write("Chọn loại phương tiện: ");
            int loai = int.Parse(Console.ReadLine()!);

            if (loai == 1)
            {
                Console.Write("Nhập số chỗ ngồi: ");
                int soCho = int.Parse(Console.ReadLine()!);

                Console.Write("Nhập dung tích động cơ: ");
                double dungTichDongCo =
                    double.Parse(Console.ReadLine()!);

                OTo oto = new OTo(
                    ma,
                    tenHang,
                    nam,
                    gia,
                    soCho,
                    dungTichDongCo
                );

                quanLy.AddPhuongTien(oto);

                Console.WriteLine("Đã thêm ô tô thành công!");
            }
            else if (loai == 2)
            {
                Console.Write("Nhập dung tích xy-lanh: ");
                int xyLanh =
                    int.Parse(Console.ReadLine()!);

                XeMay xeMay = new XeMay(
                    ma,
                    tenHang,
                    nam,
                    gia,
                    xyLanh
                );

                quanLy.AddPhuongTien(xeMay);

                Console.WriteLine("Đã thêm xe máy thành công!");
            }
            else
            {
                Console.WriteLine(
                    "Loại phương tiện không hợp lệ!"
                );
            }
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Lỗi: Bạn nhập sai định dạng số!"
            );
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(
                "Lỗi: " + ex.Message
            );
        }
    }


    // =========================================
    // CHỨC NĂNG 2: HIỂN THỊ DANH SÁCH
    // =========================================
    static void HienThiDanhSach(
        QuanLyPhuongTien quanLy)
    {
        Console.WriteLine(
            "\n===== DANH SÁCH PHƯƠNG TIỆN ====="
        );

        quanLy.DisplayAll();
    }


    // =========================================
    // CHỨC NĂNG 3: TÌM GIÁ LĂN BÁNH CAO NHẤT
    // =========================================
    static void TimGiaCaoNhat(
        QuanLyPhuongTien quanLy)
    {
        Console.WriteLine(
            "\n===== PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT ====="
        );

        PhuongTien? pt =
            quanLy.FindMaxGiaLanBanh();

        if (pt == null)
        {
            Console.WriteLine(
                "Danh sách phương tiện đang rỗng!"
            );

            return;
        }

        Console.WriteLine(pt.GetInfo());

        Console.WriteLine(
            "Giá lăn bánh: "
            + pt.TinhGiaLanBanh().ToString("N0")
            + " VNĐ"
        );
    }


    // =========================================
    // CHỨC NĂNG 4: TÌM THEO MÃ PT
    // =========================================
    static void TimTheoMaPT(
        QuanLyPhuongTien quanLy)
    {
        Console.WriteLine(
            "\n===== TÌM THEO MÃ PHƯƠNG TIỆN ====="
        );

        Console.Write("Nhập mã phương tiện cần tìm: ");
        string ma = Console.ReadLine() ?? "";

        PhuongTien? pt =
            quanLy.SearchByMaPT(ma);

        if (pt == null)
        {
            Console.WriteLine(
                "Không tìm thấy phương tiện!"
            );

            return;
        }

        Console.WriteLine("\nTìm thấy:");

        Console.WriteLine(pt.GetInfo());

        Console.WriteLine(
            "Giá lăn bánh: "
            + pt.TinhGiaLanBanh().ToString("N0")
            + " VNĐ"
        );
    }


    // =========================================
    // CHỨC NĂNG 5: TÌM THEO TÊN HÃNG
    // =========================================
    static void TimTheoTenHang(
        QuanLyPhuongTien quanLy)
    {
        Console.WriteLine(
            "\n===== TÌM THEO TÊN HÃNG ====="
        );

        Console.Write("Nhập tên hãng cần tìm: ");
        string keyword = Console.ReadLine() ?? "";

        List<PhuongTien> ketQua =
            quanLy.SearchByName(keyword);

        if (ketQua.Count == 0)
        {
            Console.WriteLine(
                "Không tìm thấy phương tiện!"
            );

            return;
        }

        Console.WriteLine("\nKết quả tìm kiếm:");

        foreach (PhuongTien pt in ketQua)
        {
            Console.WriteLine(pt.GetInfo());

            Console.WriteLine(
                "Giá lăn bánh: "
                + pt.TinhGiaLanBanh().ToString("N0")
                + " VNĐ"
            );

            Console.WriteLine(
                "--------------------------------"
            );
        }
    }


    // =========================================
    // CHỨC NĂNG 6: TÌM THEO DUNG TÍCH XY-LANH
    // =========================================
    static void TimTheoDungTichXylanh(
        QuanLyPhuongTien quanLy)
    {
        Console.WriteLine(
            "\n===== TÌM THEO DUNG TÍCH XY-LANH ====="
        );

        try
        {
            Console.Write(
                "Nhập dung tích xy-lanh cần tìm: "
            );

            int dungTich =
                int.Parse(Console.ReadLine()!);

            List<XeMay> ketQua =
                quanLy.SearchByDungTichXylanh(
                    dungTich
                );

            if (ketQua.Count == 0)
            {
                Console.WriteLine(
                    "Không tìm thấy xe máy phù hợp!"
                );

                return;
            }

            Console.WriteLine(
                "\nKết quả tìm kiếm:"
            );

            foreach (XeMay xe in ketQua)
            {
                Console.WriteLine(
                    xe.GetInfo()
                );

                Console.WriteLine(
                    "Giá lăn bánh: "
                    + xe.TinhGiaLanBanh()
                        .ToString("N0")
                    + " VNĐ"
                );

                Console.WriteLine(
                    "--------------------------------"
                );
            }
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Lỗi: Dung tích xy-lanh phải là số!"
            );
        }
    }


    // =========================================
    // MAIN
    // =========================================
    static void Main()
    {
        Console.OutputEncoding =
            System.Text.Encoding.UTF8;

        QuanLyPhuongTien quanLy =
            new QuanLyPhuongTien();

        while (true)
        {
            Console.WriteLine(
                "\n================================"
            );

            Console.WriteLine(
                "       QUẢN LÝ PHƯƠNG TIỆN"
            );

            Console.WriteLine(
                "================================"
            );

            Console.WriteLine(
                "1. Thêm phương tiện"
            );

            Console.WriteLine(
                "2. Hiển thị danh sách"
            );

            Console.WriteLine(
                "3. Tìm giá lăn bánh cao nhất"
            );

            Console.WriteLine(
                "4. Tìm theo mã phương tiện"
            );

            Console.WriteLine(
                "5. Tìm theo tên hãng"
            );

            Console.WriteLine(
                "6. Tìm theo dung tích xy-lanh"
            );

            Console.WriteLine(
                "0. Thoát"
            );

            Console.WriteLine(
                "================================"
            );

            Console.Write(
                "Nhập lựa chọn: "
            );

            string input =
                Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine(
                    "Lựa chọn phải là số!"
                );

                continue;
            }

            switch (choice)
            {
                case 1:
                    ThemPhuongTien(quanLy);
                    break;

                case 2:
                    HienThiDanhSach(quanLy);
                    break;

                case 3:
                    TimGiaCaoNhat(quanLy);
                    break;

                case 4:
                    TimTheoMaPT(quanLy);
                    break;

                case 5:
                    TimTheoTenHang(quanLy);
                    break;

                case 6:
                    TimTheoDungTichXylanh(quanLy);
                    break;

                case 0:
                    Console.WriteLine(
                        "Đã thoát chương trình!"
                    );
                    return;

                default:
                    Console.WriteLine(
                        "Lựa chọn không hợp lệ!"
                    );
                    break;
            }
        }
    }
}
