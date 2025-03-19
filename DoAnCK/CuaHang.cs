using System;
using System.Runtime.Serialization;

[Serializable]
public class CuaHang : ISerializable
{
    public string id_ch { get; set; }
    public string ten_ch { get; set; }
    public string sdt_ch { get; set; }
    public string dia_chi_ch { get; set; }
    private CuaHang() { }

    public CuaHang(string id_ch, string ten_ch, string sdt_ch, string dia_chi_ch)
    {
        this.id_ch = id_ch;
        this.ten_ch = ten_ch;
        this.dia_chi_ch = dia_chi_ch;
        this.sdt_ch = sdt_ch;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id_ch", id_ch);
        info.AddValue("ten_ch", ten_ch);
        info.AddValue("sdt_ch", sdt_ch);
        info.AddValue("dia_chi_ch", dia_chi_ch);
    }

    private CuaHang(SerializationInfo info, StreamingContext context)
    {
        id_ch = info.GetString("id_ch");
        ten_ch = info.GetString("ten_ch");
        dia_chi_ch = info.GetString("dia_chi_ch");
        sdt_ch = info.GetString("sdt_ch");
    }
}