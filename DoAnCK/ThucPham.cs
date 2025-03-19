using System;
using System.Runtime.Serialization;

[Serializable]
public class ThucPham : HangHoa
{
    private ThucPham() { }

    public ThucPham(string id, string ten_hang, uint so_luong, ulong don_gia, string img) : base(id, ten_hang, so_luong, don_gia, img)
    {

    }


    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    private ThucPham(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}