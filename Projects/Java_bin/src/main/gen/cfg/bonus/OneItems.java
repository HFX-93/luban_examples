
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.bonus;

import bright.serialization.*;



public final class OneItems extends  cfg.bonus.Bonus 
{
    public OneItems(ByteBuf _buf)
    { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());items = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.readInt(); items[i] = _e;}}
    }

    public OneItems(int[] items )
    {
            super();
        this.items = items;
    }

    public static OneItems deserializeOneItems(ByteBuf _buf)
    {
    
        return new OneItems(_buf);
    
    }

     public final int[] items;


    public static final int ID = 400179721;

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
    }

    @Override
    public String toString()
    {
        return "{ "
        + "items:" + items + ","
        + "}";
    }
}

