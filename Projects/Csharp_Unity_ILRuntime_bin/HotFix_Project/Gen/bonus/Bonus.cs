
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

public abstract class Bonus :  Bright.Config.BeanBase 
{
    public Bonus(ByteBuf _buf) 
    {
    }

    public static Bonus DeserializeBonus(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case bonus.OneItem.__ID__: return new bonus.OneItem(_buf);
            case bonus.OneItems.__ID__: return new bonus.OneItems(_buf);
            case bonus.Item.__ID__: return new bonus.Item(_buf);
            case bonus.Items.__ID__: return new bonus.Items(_buf);
            case bonus.CoefficientItem.__ID__: return new bonus.CoefficientItem(_buf);
            case bonus.WeightItems.__ID__: return new bonus.WeightItems(_buf);
            case bonus.ProbabilityItems.__ID__: return new bonus.ProbabilityItems(_buf);
            case bonus.MultiBonus.__ID__: return new bonus.MultiBonus(_buf);
            case bonus.ProbabilityBonus.__ID__: return new bonus.ProbabilityBonus(_buf);
            case bonus.WeightBonus.__ID__: return new bonus.WeightBonus(_buf);
            case bonus.DropBonus.__ID__: return new bonus.DropBonus(_buf);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    }

}
