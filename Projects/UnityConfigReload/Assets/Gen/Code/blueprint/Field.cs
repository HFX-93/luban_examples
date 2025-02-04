//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.blueprint
{

public sealed partial class Field :  Bright.Config.BeanBase 
{
    public Field(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Type = _buf.ReadString();
        Desc = _buf.ReadString();
        PostInit();
    }

    public static Field DeserializeField(ByteBuf _buf)
    {
        return new blueprint.Field(_buf);
    }

    public string Name { get; protected set; }
    public string Type { get; protected set; }
    public string Desc { get; protected set; }

    public const int __ID__ = 1694158271;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(Field reloadData)
    {
        Name = reloadData.Name;
        Type = reloadData.Type;
        Desc = reloadData.Desc;
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Type:" + Type + ","
        + "Desc:" + Desc + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
