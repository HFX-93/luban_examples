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

public sealed class Equipment :  test.ItemBase 
{
    public Equipment(ByteBuf _buf)  : base(_buf) 
    {
        Attr = (test.DemoEnum)_buf.ReadInt();
        Value = _buf.ReadInt();
    }

    public static Equipment DeserializeEquipment(ByteBuf _buf)
    {
        return new test.Equipment(_buf);
    }

    public test.DemoEnum Attr { get; private set; }
    public int Value { get; private set; }

    public const int __ID__ = -76837102;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Attr:" + Attr + ","
        + "Value:" + Value + ","
        + "}";
    }
    }

}
