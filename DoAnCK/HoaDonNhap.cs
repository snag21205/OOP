using System;
using System.Runtime.Serialization;

namespace DoAnCK
{
    [Serializable]
    public class HoaDonNhap : HoaDon
    {
        public NhaCungCap nha_cung_cap { get; set; }
        private HoaDonNhap() { }
        public HoaDonNhap(QuanLyNhapXuat qlnx, string id_hoa_don, NhanVien nv_lap, NhaCungCap nha_cung_cap, ulong tong_tien) : base(qlnx, id_hoa_don, nv_lap, tong_tien)
        {
            this.nha_cung_cap = nha_cung_cap;
            ngay_tao_don = DateTime.Now;
        }

        public override string SetID()
        {
            return "HDN";
        }


        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("nha_cung_cap", nha_cung_cap);
        }

        private HoaDonNhap(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            nha_cung_cap = (NhaCungCap)info.GetValue("nha_cung_cap", typeof(NhaCungCap));
        }
    }
}