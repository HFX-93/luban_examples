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

public sealed class UeCooldown :  ai.Decorator 
{
    public UeCooldown(ByteBuf _buf)  : base(_buf) 
    {
        CooldownTime = _buf.ReadFloat();
    }

    public static UeCooldown DeserializeUeCooldown(ByteBuf _buf)
    {
        return new ai.UeCooldown(_buf);
    }

    public float CooldownTime { get; private set; }

    public const int __ID__ = -951439423;
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
        + "NodeName:" + NodeName + ","
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "CooldownTime:" + CooldownTime + ","
        + "}";
    }
    }

}
