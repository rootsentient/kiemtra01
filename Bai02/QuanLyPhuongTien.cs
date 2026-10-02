using System;
using System.Collections.Generic;

class QuanLyPhuongTien
{
    // =========================
    // DANH SÁCH PHƯƠNG TIỆN
    // =========================
    private List<PhuongTien> danhSach;


    // =========================
    // CONSTRUCTOR
    // =========================
    public QuanLyPhuongTien()
    {
        danhSach =
            new List<PhuongTien>();
    }


    // =====================================
    // 1. THÊM PHƯƠNG TIỆN
    // =====================================
    public void AddPhuongTien(
        PhuongTien pt)
    {
        danhSach.Add(pt);
    }


    // =====================================
    // 2. HIỂN THỊ TOÀN BỘ
    // =====================================
    public void DisplayAll()
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine(
                "Danh sách phương tiện đang rỗng!"
            );

            return;
        }

        foreach (PhuongTien pt
                 in danhSach)
        {
            Console.WriteLine(
                pt.GetInfo()
            );

            Console.WriteLine(
                "Giá lăn bánh: "
                + pt.TinhGiaLanBanh()
                    .ToString("N0")
                + " VNĐ"
            );

            Console.WriteLine(
                "--------------------------------"
            );
        }
    }


    // =====================================
    // 3. TÌM GIÁ LĂN BÁNH CAO NHẤT
    // =====================================
    public PhuongTien? FindMaxGiaLanBanh()
    {
        if (danhSach.Count == 0)
        {
            return null;
        }

        PhuongTien max =
            danhSach[0];

        foreach (PhuongTien pt
                 in danhSach)
        {
            if (pt.TinhGiaLanBanh()
                > max.TinhGiaLanBanh())
            {
                max = pt;
            }
        }

        return max;
    }


    // =====================================
    // 4. TÌM THEO MÃ PHƯƠNG TIỆN
    // =====================================
    public PhuongTien? SearchByMaPT(
        string maPT)
    {
        foreach (PhuongTien pt
                 in danhSach)
        {
            if (pt.MaPT.Equals(
                maPT,
                StringComparison.OrdinalIgnoreCase))
            {
                return pt;
            }
        }

        return null;
    }


    // =====================================
    // 5. TÌM THEO TÊN HÃNG
    // =====================================
    public List<PhuongTien> SearchByName(
        string keyword)
    {
        List<PhuongTien> ketQua =
            new List<PhuongTien>();

        foreach (PhuongTien pt
                 in danhSach)
        {
            if (pt.TenHang.Contains(
                keyword,
                StringComparison.OrdinalIgnoreCase))
            {
                ketQua.Add(pt);
            }
        }

        return ketQua;
    }


    // =====================================
    // 6. TÌM THEO DUNG TÍCH XY-LANH
    // =====================================
    public List<XeMay> SearchByDungTichXylanh(
        int dungTich)
    {
        List<XeMay> ketQua =
            new List<XeMay>();

        foreach (PhuongTien pt
                 in danhSach)
        {
            // Chỉ XeMay mới có DungTichXylanh
            if (pt is XeMay xeMay)
            {
                if (xeMay.DungTichXylanh
                    == dungTich)
                {
                    ketQua.Add(xeMay);
                }
            }
        }

        return ketQua;
    }
}
