
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.cost
{

public sealed partial class CostItem :  cost.Cost 
{
    public CostItem(ByteBuf _buf)  : base(_buf) 
    {
        ItemId = _buf.ReadInt();
        Amount = _buf.ReadInt();
    }

    public CostItem(int item_id, int amount )  : base() 
    {
        this.ItemId = item_id;
        this.Amount = amount;
    }

    public static CostItem DeserializeCostItem(ByteBuf _buf)
    {
        return new cost.CostItem(_buf);
    }

    public readonly int ItemId;
    public item.Item ItemId_Ref;
    public readonly int Amount;

    public const int ID = -1249440351;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "Amount:" + Amount + ","
        + "}";
    }
    }

}

