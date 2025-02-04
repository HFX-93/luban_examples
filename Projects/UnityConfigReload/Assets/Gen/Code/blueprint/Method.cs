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

public abstract partial class Method :  Bright.Config.BeanBase 
{
    public Method(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        IsStatic = _buf.ReadBool();
        ReturnType = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Parameters = new System.Collections.Generic.List<blueprint.ParamInfo>(n);for(var i = 0 ; i < n ; i++) { blueprint.ParamInfo _e;  _e = blueprint.ParamInfo.DeserializeParamInfo(_buf); Parameters.Add(_e);}}
        PostInit();
    }

    public static Method DeserializeMethod(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case blueprint.AbstraceMethod.__ID__: return new blueprint.AbstraceMethod(_buf);
            case blueprint.ExternalMethod.__ID__: return new blueprint.ExternalMethod(_buf);
            case blueprint.BlueprintMethod.__ID__: return new blueprint.BlueprintMethod(_buf);
            default: throw new SerializationException();
        }
    }

    public string Name { get; protected set; }
    public string Desc { get; protected set; }
    public bool IsStatic { get; protected set; }
    public string ReturnType { get; protected set; }
    public System.Collections.Generic.List<blueprint.ParamInfo> Parameters { get; protected set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Parameters) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Parameters) { _e?.TranslateText(translator); }
    }

    public void Reload(Method reloadData)
    {
        Name = reloadData.Name;
        Desc = reloadData.Desc;
        IsStatic = reloadData.IsStatic;
        ReturnType = reloadData.ReturnType;
        if(Parameters==null)
        {
            Parameters = reloadData.Parameters;
        }else
        {
            Parameters.Capacity = reloadData.Parameters.Count;
            for (int i = 0; i < reloadData.Parameters.Count; i++)
            {
                if(Parameters[i]!=null)
                {
                    Parameters[i].Reload(reloadData.Parameters[i]);
                }else
                {
                    Parameters[i] = reloadData.Parameters[i];
                }
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "ReturnType:" + ReturnType + ","
        + "Parameters:" + Bright.Common.StringUtil.CollectionToString(Parameters) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
