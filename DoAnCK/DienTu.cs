using System;
using System.Runtime.Serialization;

[Serializable]
public class DienTu : HangHoa
{
    private DienTu() { }

    public DienTu(string id, string ten_hang, uint so_luong, ulong don_gia, string img) : base(id, ten_hang, so_luong, don_gia, img)
    {

    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    private DienTu(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}