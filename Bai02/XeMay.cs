using System;

class XeMay : PhuongTien
{
    // =========================
    // FIELD
    // =========================
    private int _dungTichXylanh;


    // =========================
    // PROPERTY DUNG TÍCH XY-LANH
    // =========================
    public int DungTichXylanh
    {
        get
        {
            return _dungTichXylanh;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "Dung tích xy-lanh phải lớn hơn 0!"
                );
            }

            _dungTichXylanh = value;
        }
    }


    // =========================
    // CONSTRUCTOR
    // =========================
    public XeMay(
        string maPT,
        string tenHang,
        int namSanXuat,
        decimal giaGoc,
        int dungTichXylanh)
        : base(
            maPT,
            tenHang,
            namSanXuat,
            giaGoc)
    {
        DungTichXylanh =
            dungTichXylanh;
    }


    // =========================
    // TÍNH GIÁ LĂN BÁNH
    // =========================
    public override decimal TinhGiaLanBanh()
    {
        if (DungTichXylanh < 175)
        {
            decimal lePhiTruocBa =
                GiaGoc * 0.02m;

            return GiaGoc
                   + lePhiTruocBa;
        }
        else
        {
            decimal lePhiTruocBa =
                GiaGoc * 0.05m;

            return GiaGoc
                   + lePhiTruocBa;
        }
    }


    // =========================
    // HIỂN THỊ THÔNG TIN
    // =========================
    public override string GetInfo()
    {
        return base.GetInfo()
             + " | Loại: Xe máy"
             + " | Dung tích xy-lanh: "
             + DungTichXylanh
             + " cc";
    }
}
