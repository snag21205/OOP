using System.Runtime.Serialization;
using System.Xml.Serialization;
using System;

namespace DoAnCK
{
    [XmlInclude(typeof(HoaDonNhap))]
    [XmlInclude(typeof(HoaDonXuat))]
    [Serializable]
    public abstract class HoaDon : ISerializable
    {
        public string id_hoa_don { get; set; }
        public DateTime ngay_tao_don { get; set; }
        public QuanLyNhapXuat qlnx { get; set; }
        public NhanVien nv_lap { get; set; }
        public ulong tong_tien { get; set; }

        protected HoaDon() { }
        public HoaDon(QuanLyNhapXuat qlnx, string id_hoa_don, NhanVien nv_lap, ulong tong_tien)
        {
            this.ngay_tao_don = DateTime.Now;
            this.id_hoa_don = id_hoa_don;
            this.qlnx = qlnx;
            this.nv_lap = nv_lap;
            this.tong_tien = tong_tien;
        }

        public abstract string SetID();

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id_hoa_don", id_hoa_don);
            info.AddValue("ngay_tao_don", ngay_tao_don);
            info.AddValue("qlnx", qlnx);
            info.AddValue("nv_lap", nv_lap);
            info.AddValue("tong_tien", tong_tien);
        }

        protected HoaDon(SerializationInfo info, StreamingContext context)
        {
            id_hoa_don = info.GetString("id_hoa_don");
            ngay_tao_don = (DateTime)info.GetValue("ngay_tao_don", typeof(DateTime));
            qlnx = (QuanLyNhapXuat)info.GetValue("qlnx", typeof(QuanLyNhapXuat));
            nv_lap = (NhanVien)info.GetValue("nv_lap", typeof(NhanVien));
            tong_tien = info.GetUInt64("tong_tien");
        }
    }
}