
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

public sealed class TestMultiColumn :  Bright.Config.BeanBase 
{
    public TestMultiColumn(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        A =  test.Foo.DeserializeFoo(_json.GetProperty("a"));
        B =  test.Foo.DeserializeFoo(_json.GetProperty("b"));
        C =  test.Foo.DeserializeFoo(_json.GetProperty("c"));
    }

    public TestMultiColumn(int id, test.Foo a, test.Foo b, test.Foo c ) 
    {
        this.Id = id;
        this.A = a;
        this.B = b;
        this.C = c;
    }

    public static TestMultiColumn DeserializeTestMultiColumn(JsonElement _json)
    {
        return new test.TestMultiColumn(_json);
    }

    public int Id { get; private set; }
    public test.Foo A { get; private set; }
    public test.Foo B { get; private set; }
    public test.Foo C { get; private set; }

    public const int __ID__ = -294473599;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        A?.Resolve(_tables);
        B?.Resolve(_tables);
        C?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        A?.TranslateText(translator);
        B?.TranslateText(translator);
        C?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "A:" + A + ","
        + "B:" + B + ","
        + "C:" + C + ","
        + "}";
    }
    }
}
