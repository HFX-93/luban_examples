
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

public sealed partial class GetOwnerPlayer :  ai.Service 
{
    public GetOwnerPlayer(ByteBuf _buf)  : base(_buf) 
    {
        PlayerActorKey = _buf.ReadString();
    }

    public GetOwnerPlayer(int id, string node_name, string player_actor_key )  : base(id,node_name) 
    {
        this.PlayerActorKey = player_actor_key;
    }

    public static GetOwnerPlayer DeserializeGetOwnerPlayer(ByteBuf _buf)
    {
        return new ai.GetOwnerPlayer(_buf);
    }

    public readonly string PlayerActorKey;

    public const int ID = -999247644;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

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

