
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public sealed class IntKeyData :  ai.KeyData 
{
    public IntKeyData(ByteBuf _buf)  : base(_buf) 
    {
        Value = _buf.ReadInt();
    }

    public static IntKeyData DeserializeIntKeyData(ByteBuf _buf)
    {
        return new ai.IntKeyData(_buf);
    }

    public int Value { get; private set; }

    public const int __ID__ = -342751904;
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
        + "Value:" + Value + ","
        + "}";
    }
    }

}
