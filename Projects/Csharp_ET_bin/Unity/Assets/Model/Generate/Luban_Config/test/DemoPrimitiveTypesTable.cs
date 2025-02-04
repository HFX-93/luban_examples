
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class DemoPrimitiveTypesTable :  Bright.Config.BeanBase 
{
    public DemoPrimitiveTypesTable(ByteBuf _buf) 
    {
        X1 = _buf.ReadBool();
        X2 = _buf.ReadByte();
        X3 = _buf.ReadShort();
        X4 = _buf.ReadInt();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        X7 = _buf.ReadDouble();
        S1 = _buf.ReadString();
        S2 = _buf.ReadString();
        V2 = _buf.ReadVector2();
        V3 = _buf.ReadVector3();
        V4 = _buf.ReadVector4();
        T1 = _buf.ReadInt();
    }

    public DemoPrimitiveTypesTable(bool x1, byte x2, short x3, int x4, long x5, float x6, double x7, string s1, string s2, System.Numerics.Vector2 v2, System.Numerics.Vector3 v3, System.Numerics.Vector4 v4, int t1 ) 
    {
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.X5 = x5;
        this.X6 = x6;
        this.X7 = x7;
        this.S1 = s1;
        this.S2 = s2;
        this.V2 = v2;
        this.V3 = v3;
        this.V4 = v4;
        this.T1 = t1;
    }

    public static DemoPrimitiveTypesTable DeserializeDemoPrimitiveTypesTable(ByteBuf _buf)
    {
        return new test.DemoPrimitiveTypesTable(_buf);
    }

    public readonly bool X1;
    public readonly byte X2;
    public readonly short X3;
    public readonly int X4;
    public readonly long X5;
    public readonly float X6;
    public readonly double X7;
    public readonly string S1;
    public readonly string S2;
    public readonly System.Numerics.Vector2 V2;
    public readonly System.Numerics.Vector3 V3;
    public readonly System.Numerics.Vector4 V4;
    public readonly int T1;

    public const int ID = -370934083;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X7:" + X7 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "}";
    }
    }

}

