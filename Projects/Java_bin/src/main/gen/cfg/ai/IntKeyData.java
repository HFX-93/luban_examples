
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import bright.serialization.*;



public final class IntKeyData extends cfg.ai.KeyData {
    public IntKeyData(ByteBuf _buf) { 
        super(_buf);
        value = _buf.readInt();
    }

    public IntKeyData(int value ) {
        super();
        this.value = value;
    }


    public final int value;

    public static final int __ID__ = -342751904;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "value:" + value + ","
        + "}";
    }
}
