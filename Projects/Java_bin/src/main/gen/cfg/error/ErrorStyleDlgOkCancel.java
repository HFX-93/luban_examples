
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.error;

import bright.serialization.*;



public final class ErrorStyleDlgOkCancel extends  cfg.error.ErrorStyle 
{
    public ErrorStyleDlgOkCancel(ByteBuf _buf)
    { 
        super(_buf);
        btn1Name = _buf.readString();
        btn2Name = _buf.readString();
    }

    public ErrorStyleDlgOkCancel(String btn1_name, String btn2_name )
    {
            super();
        this.btn1Name = btn1_name;
        this.btn2Name = btn2_name;
    }

    public static ErrorStyleDlgOkCancel deserializeErrorStyleDlgOkCancel(ByteBuf _buf)
    {
    
        return new ErrorStyleDlgOkCancel(_buf);
    
    }

     public final String btn1Name;
     public final String btn2Name;


    public static final int ID = 971221414;

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
        + "btn1Name:" + btn1Name + ","
        + "btn2Name:" + btn2Name + ","
        + "}";
    }
}

