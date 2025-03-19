using System.Runtime.Serialization;
using System;
using System.Web.Management;

namespace DoAnCK
{
    [Serializable]
    public class HoaDonXuat : HoaDon
    {
        public CuaHang cua_hang { get; set; }
        private HoaDonXuat() { }
        public HoaDonXuat(QuanLyNhapXuat qlnx, string id_hoa_don, NhanVien nv_lap, CuaHang cua_hang, ulong tong_tien) : base(qlnx, id_hoa_don, nv_lap, tong_tien)
        {
            ngay_tao_don = DateTime.Now;
            this.cua_hang = cua_hang;
        }

        public override string SetID()
        {
            return "HDX";
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("cua_hang", cua_hang);
        }

        private HoaDonXuat(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            cua_hang = (CuaHang)info.GetValue("cua_hang", typeof(CuaHang));
        }
    }
}