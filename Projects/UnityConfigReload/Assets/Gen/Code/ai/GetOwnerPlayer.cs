//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.ai
{

public sealed partial class GetOwnerPlayer :  ai.Service 
{
    public GetOwnerPlayer(ByteBuf _buf)  : base(_buf) 
    {
        PlayerActorKey = _buf.ReadString();
        PostInit();
    }

    public static GetOwnerPlayer DeserializeGetOwnerPlayer(ByteBuf _buf)
    {
        return new ai.GetOwnerPlayer(_buf);
    }

    public string PlayerActorKey { get; protected set; }

    public const int __ID__ = -999247644;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public void Reload(GetOwnerPlayer reloadData)
    {
        Id = reloadData.Id;
        NodeName = reloadData.NodeName;
        PlayerActorKey = reloadData.PlayerActorKey;
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "PlayerActorKey:" + PlayerActorKey + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
