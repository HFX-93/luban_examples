
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

public sealed class DemoGroup :  Bright.Config.BeanBase 
{
    public DemoGroup(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X1 = _buf.ReadInt();
        X2 = _buf.ReadInt();
        X3 = _buf.ReadInt();
        X4 = _buf.ReadInt();
        X5 = test.InnerGroup.DeserializeInnerGroup(_buf);
    }

    public static DemoGroup DeserializeDemoGroup(ByteBuf _buf)
    {
        return new test.DemoGroup(_buf);
    }

    public int Id { get; private set; }
    public int X1 { get; private set; }
    public int X2 { get; private set; }
    public int X3 { get; private set; }
    public int X4 { get; private set; }
    public test.InnerGroup X5 { get; private set; }

    public const int __ID__ = -379263008;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X5?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X5?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "X5:" + X5 + ","
        + "}";
    }
    }

}
