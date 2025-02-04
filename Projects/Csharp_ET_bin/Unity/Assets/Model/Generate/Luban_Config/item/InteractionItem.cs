
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

public sealed partial class InteractionItem :  item.ItemExtra 
{
    public InteractionItem(ByteBuf _buf)  : base(_buf) 
    {
        if(_buf.ReadBool()){ AttackNum = _buf.ReadInt(); } else { AttackNum = null; }
        HoldingStaticMesh = _buf.ReadString();
        HoldingStaticMeshMat = _buf.ReadString();
    }

    public InteractionItem(int id, int? attack_num, string holding_static_mesh, string holding_static_mesh_mat )  : base(id) 
    {
        this.AttackNum = attack_num;
        this.HoldingStaticMesh = holding_static_mesh;
        this.HoldingStaticMeshMat = holding_static_mesh_mat;
    }

    public static InteractionItem DeserializeInteractionItem(ByteBuf _buf)
    {
        return new item.InteractionItem(_buf);
    }

    public readonly int? AttackNum;
    public readonly string HoldingStaticMesh;
    public readonly string HoldingStaticMeshMat;

    public const int ID = 640937802;
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
        + "AttackNum:" + AttackNum + ","
        + "HoldingStaticMesh:" + HoldingStaticMesh + ","
        + "HoldingStaticMeshMat:" + HoldingStaticMeshMat + ","
        + "}";
    }
    }

}

