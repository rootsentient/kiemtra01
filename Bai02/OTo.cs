using System;

class OTo : PhuongTien
{
    // =========================
    // FIELDS
    // =========================
    private int _soChoNgoi;
    private double _dungTichDongCo;


    // =========================
    // PROPERTY SỐ CHỖ NGỒI
    // =========================
    public int SoChoNgoi
    {
        get
        {
            return _soChoNgoi;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "Số chỗ ngồi phải lớn hơn 0!"
                );
            }

            _soChoNgoi = value;
        }
    }


    // =========================
    // PROPERTY DUNG TÍCH ĐỘNG CƠ
    // =========================
    public double DungTichDongCo
    {
        get
        {
            return _dungTichDongCo;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "Dung tích động cơ phải lớn hơn 0!"
                );
            }

            _dungTichDongCo = value;
        }
    }


    // =========================
    // CONSTRUCTOR
    // =========================
    public OTo(
        string maPT,
        string tenHang,
        int namSanXuat,
        decimal giaGoc,
        int soChoNgoi,
        double dungTichDongCo)
        : base(
            maPT,
            tenHang,
            namSanXuat,
            giaGoc)
    {
        SoChoNgoi = soChoNgoi;
        DungTichDongCo = dungTichDongCo;
    }


    // =========================
    // TÍNH GIÁ LĂN BÁNH
    // =========================
    public override decimal TinhGiaLanBanh()
    {
        // Ô tô từ 9 chỗ trở xuống
        if (SoChoNgoi <= 9)
        {
            decimal lePhiTruocBa =
                GiaGoc * 0.12m;

            decimal thueTieuThuDacBiet =
                GiaGoc * 0.30m;

            return GiaGoc
                   + lePhiTruocBa
                   + thueTieuThuDacBiet;
        }

        // Ô tô trên 9 chỗ
        else
        {
            decimal lePhiTruocBa =
                GiaGoc * 0.10m;

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
             + " | Loại: Ô tô"
             + " | Số chỗ: "
             + SoChoNgoi
             + " | Dung tích động cơ: "
             + DungTichDongCo
             + " L";
    }
}
