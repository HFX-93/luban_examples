
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.blueprint;

import bright.serialization.*;



public final class Field extends  bright.serialization.AbstractBean 
{
    public Field(ByteBuf _buf)
    { 
        name = _buf.readString();
        type = _buf.readString();
        desc = _buf.readString();
    }

    public Field(String name, String type, String desc )
    {
        this.name = name;
        this.type = type;
        this.desc = desc;
    }

    public static Field deserializeField(ByteBuf _buf)
    {
    
        return new Field(_buf);
    
    }

     public final String name;
     public final String type;
     public final String desc;


    public static final int ID = 1694158271;

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

    }

    @Override
    public String toString()
    {
        return "{ "
        + "name:" + name + ","
        + "type:" + type + ","
        + "desc:" + desc + ","
        + "}";
    }
}

