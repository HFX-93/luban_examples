
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

public sealed class Foo :  Bright.Config.BeanBase 
{
    public Foo(JsonElement _json) 
    {
        Y1 = _json.GetProperty("y1").GetInt32();
        Y2 = _json.GetProperty("y2").GetInt32();
        Y3 = _json.GetProperty("y3").GetInt32();
    }

    public Foo(int y1, int y2, int y3 ) 
    {
        this.Y1 = y1;
        this.Y2 = y2;
        this.Y3 = y3;
    }

    public static Foo DeserializeFoo(JsonElement _json)
    {
        return new test.Foo(_json);
    }

    public int Y1 { get; private set; }
    public int Y2 { get; private set; }
    public int Y3 { get; private set; }

    public const int __ID__ = -1147950774;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Y1:" + Y1 + ","
        + "Y2:" + Y2 + ","
        + "Y3:" + Y3 + ","
        + "}";
    }
    }
}
