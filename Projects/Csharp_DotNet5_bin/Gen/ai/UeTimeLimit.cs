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

public sealed class UeTimeLimit :  ai.Decorator 
{
    public UeTimeLimit(ByteBuf _buf)  : base(_buf) 
    {
        LimitTime = _buf.ReadFloat();
    }

    public static UeTimeLimit DeserializeUeTimeLimit(ByteBuf _buf)
    {
        return new ai.UeTimeLimit(_buf);
    }

    public float LimitTime { get; private set; }

    public const int __ID__ = 338469720;
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
        + "LimitTime:" + LimitTime + ","
        + "}";
    }
    }

}
