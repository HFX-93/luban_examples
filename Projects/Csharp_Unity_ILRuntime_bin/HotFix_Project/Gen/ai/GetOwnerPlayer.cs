
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

public sealed class GetOwnerPlayer :  ai.Service 
{
    public GetOwnerPlayer(ByteBuf _buf)  : base(_buf) 
    {
        PlayerActorKey = _buf.ReadString();
    }

    public static GetOwnerPlayer DeserializeGetOwnerPlayer(ByteBuf _buf)
    {
        return new ai.GetOwnerPlayer(_buf);
    }

    public string PlayerActorKey { get; private set; }

    public const int __ID__ = -999247644;
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
        + "PlayerActorKey:" + PlayerActorKey + ","
        + "}";
    }
    }

}
