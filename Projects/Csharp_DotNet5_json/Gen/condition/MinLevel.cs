
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.condition
{

public sealed class MinLevel :  condition.BoolRoleCondition 
{
    public MinLevel(JsonElement _json)  : base(_json) 
    {
        Level = _json.GetProperty("level").GetInt32();
    }

    public MinLevel(int level )  : base() 
    {
        this.Level = level;
    }

    public static MinLevel DeserializeMinLevel(JsonElement _json)
    {
        return new condition.MinLevel(_json);
    }

    public int Level { get; private set; }

    public const int ID = -1075273755;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Level:" + Level + ","
        + "}";
    }
    }
}
