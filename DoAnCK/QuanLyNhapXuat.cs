using System.Collections.Generic;

namespace DoAnCK
{
    public class QuanLyNhapXuat
    {
        public List<HangHoa> ds_hang_hoa = new List<HangHoa>();

        public void them_hh(HangHoa hh)
        {
            ds_hang_hoa.Add(hh);
        }

        public void xoa_hh(HangHoa hh)
        {
            ds_hang_hoa.Remove(hh);
        }

        public void tang_sl(HangHoa hh)
        {
            hh.so_luong++;
        }
        public void giam_sl(HangHoa hh)
        {
            if (hh.so_luong > 1)
            {
                hh.so_luong--;
            }
        }
        public void cap_nhat_sl(HangHoa hh, uint sl_moi)
        {
            hh.so_luong = sl_moi;
        }

        public bool ton_tai(HangHoa hh)
        {
            HangHoa hh_check = ds_hang_hoa.Find(x => x.id == hh.id);
            if (hh_check != null)
            {
                return true;
            }
            return false;
        }

        public ulong tinh_tong_tien()
        {
            ulong tong_tien = 0;
            foreach(HangHoa hh in ds_hang_hoa)
            {
                tong_tien += hh.don_gia * hh.so_luong;
            }    
            return tong_tien;
        }
    }
}
