//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.blueprint
{

public abstract class Clazz :  Bright.Config.BeanBase 
{
    public Clazz(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Parents = new System.Collections.Generic.List<blueprint.Clazz>(n);for(var i = 0 ; i < n ; i++) { blueprint.Clazz _e;  _e = blueprint.Clazz.DeserializeClazz(_buf); Parents.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Methods = new System.Collections.Generic.List<blueprint.Method>(n);for(var i = 0 ; i < n ; i++) { blueprint.Method _e;  _e = blueprint.Method.DeserializeMethod(_buf); Methods.Add(_e);}}
    }

    public static Clazz DeserializeClazz(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case blueprint.Interface.__ID__: return new blueprint.Interface(_buf);
            case blueprint.NormalClazz.__ID__: return new blueprint.NormalClazz(_buf);
            case blueprint.EnumClazz.__ID__: return new blueprint.EnumClazz(_buf);
            default: throw new SerializationException();
        }
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public System.Collections.Generic.List<blueprint.Clazz> Parents { get; private set; }
    public System.Collections.Generic.List<blueprint.Method> Methods { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Parents) { _e?.Resolve(_tables); }
        foreach(var _e in Methods) { _e?.Resolve(_tables); }
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Parents) { _e?.TranslateText(translator); }
        foreach(var _e in Methods) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "}";
    }
    }

}
