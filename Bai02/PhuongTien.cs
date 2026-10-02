using System;

abstract class PhuongTien
{
    // =========================
    // FIELDS
    // =========================
    private string _maPT = "";
    private string _tenHang = "";
    private int _namSanXuat;
    private decimal _giaGoc;


    // =========================
    // PROPERTY MÃ PHƯƠNG TIỆN
    // =========================
    public string MaPT
    {
        get
        {
            return _maPT;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _maPT = "PT000";
            }
            else
            {
                _maPT = value.Trim();
            }
        }
    }


    // =========================
    // PROPERTY TÊN HÃNG
    // =========================
    public string TenHang
    {
        get
        {
            return _tenHang;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "Tên hãng không được để trống!"
                );
            }

            _tenHang = value.Trim();
        }
    }


    // =========================
    // PROPERTY NĂM SẢN XUẤT
    // =========================
    public int NamSanXuat
    {
        get
        {
            return _namSanXuat;
        }

        set
        {
            int namHienTai = DateTime.Now.Year;

            if (value < 1900 || value > namHienTai)
            {
                throw new ArgumentException(
                    "Năm sản xuất phải từ 1900 đến "
                    + namHienTai
                );
            }

            _namSanXuat = value;
        }
    }


    // =========================
    // PROPERTY GIÁ GỐC
    // =========================
    public decimal GiaGoc
    {
        get
        {
            return _giaGoc;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "Giá gốc phải lớn hơn 0!"
                );
            }

            _giaGoc = value;
        }
    }


    // =========================
    // CONSTRUCTOR
    // =========================
    public PhuongTien(
        string maPT,
        string tenHang,
        int namSanXuat,
        decimal giaGoc)
    {
        MaPT = maPT;
        TenHang = tenHang;
        NamSanXuat = namSanXuat;
        GiaGoc = giaGoc;
    }


    // =========================
    // ABSTRACT METHOD
    // =========================
    public abstract decimal TinhGiaLanBanh();


    // =========================
    // GET INFO
    // =========================
    public virtual string GetInfo()
    {
        return "Mã PT: " + MaPT
             + " | Hãng: " + TenHang
             + " | Năm SX: " + NamSanXuat
             + " | Giá gốc: "
             + GiaGoc.ToString("N0")
             + " VNĐ";
    }
}
