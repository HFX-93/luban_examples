
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.cost;

import bright.serialization.*;



public final class CostOneItem extends  cfg.cost.Cost 
{
    public CostOneItem(ByteBuf _buf)
    { 
        super(_buf);
        itemId = _buf.readInt();
    }

    public CostOneItem(int item_id )
    {
            super();
        this.itemId = item_id;
    }

    public static CostOneItem deserializeCostOneItem(ByteBuf _buf)
    {
    
        return new CostOneItem(_buf);
    
    }

     public final int itemId;
        public cfg.item.Item itemId_Ref;


    public static final int ID = -1033587381;

    @Override
    public int getTypeId() { return ID; }


    @Override
    public void serialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    @Override
    public void deserialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
super.resolve(_tables);
            this.itemId_Ref = ((cfg.item.TbItem)_tables.get("item.TbItem")).get(itemId);
    }

    @Override
    public String toString()
    {
        return "{ "
        + "itemId:" + itemId + ","
        + "}";
    }
}

