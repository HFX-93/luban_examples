
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.bonus;

import bright.serialization.*;



public final class Item extends  cfg.bonus.Bonus 
{
    public Item(ByteBuf _buf)
    { 
        super(_buf);
        itemId = _buf.readInt();
        amount = _buf.readInt();
    }

    public Item(int item_id, int amount )
    {
            super();
        this.itemId = item_id;
        this.amount = amount;
    }

    public static Item deserializeItem(ByteBuf _buf)
    {
    
        return new Item(_buf);
    
    }

     public final int itemId;
        public cfg.item.Item itemId_Ref;
     public final int amount;


    public static final int ID = 1689011106;

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
        + "amount:" + amount + ","
        + "}";
    }
}

