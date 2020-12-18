
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import bright.serialization.*;



public final class UeCooldown extends  cfg.ai.Decorator 
{
    public UeCooldown(ByteBuf _buf)
    { 
        super(_buf);
        cooldownTime = _buf.readFloat();
    }

    public UeCooldown(int id, String node_name, cfg.ai.EFlowAbortMode flow_abort_mode, float cooldown_time )
    {
            super(id, node_name, flow_abort_mode);
        this.cooldownTime = cooldown_time;
    }

    public static UeCooldown deserializeUeCooldown(ByteBuf _buf)
    {
    
        return new UeCooldown(_buf);
    
    }

     public final float cooldownTime;


    public static final int ID = -951439423;

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
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "cooldownTime:" + cooldownTime + ","
        + "}";
    }
}

