
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.bonus;

import bright.serialization.*;



public final class CoefficientItem extends  cfg.bonus.Bonus 
{
    public CoefficientItem(ByteBuf _buf)
    { 
        super(_buf);
        bonusId = _buf.readInt();
        bonusList = cfg.bonus.Items.deserializeItems(_buf);
    }

    public CoefficientItem(int bonus_id, cfg.bonus.Items bonus_list )
    {
            super();
        this.bonusId = bonus_id;
        this.bonusList = bonus_list;
    }

    public static CoefficientItem deserializeCoefficientItem(ByteBuf _buf)
    {
    
        return new CoefficientItem(_buf);
    
    }

     public final int bonusId;
     public final cfg.bonus.Items bonusList;


    public static final int ID = -229470727;

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
            if (bonusList != null) {bonusList.resolve(_tables);}
    }

    @Override
    public String toString()
    {
        return "{ "
        + "bonusId:" + bonusId + ","
        + "bonusList:" + bonusList + ","
        + "}";
    }
}

