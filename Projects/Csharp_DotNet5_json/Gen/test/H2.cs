
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



namespace cfg.test
{

public sealed class H2 :  Bright.Config.BeanBase 
{
    public H2(JsonElement _json) 
    {
        Z2 = _json.GetProperty("z2").GetInt32();
        Z3 = _json.GetProperty("z3").GetInt32();
    }

    public H2(int z2, int z3 ) 
    {
        this.Z2 = z2;
        this.Z3 = z3;
    }

    public static H2 DeserializeH2(JsonElement _json)
    {
        return new test.H2(_json);
    }

    public int Z2 { get; private set; }
    public int Z3 { get; private set; }

    public const int ID = -1422503994;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Z2:" + Z2 + ","
        + "Z3:" + Z3 + ","
        + "}";
    }
    }
}
