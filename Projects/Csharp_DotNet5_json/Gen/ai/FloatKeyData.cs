
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



namespace cfg.ai
{

public sealed class FloatKeyData :  ai.KeyData 
{
    public FloatKeyData(JsonElement _json)  : base(_json) 
    {
        Value = _json.GetProperty("value").GetSingle();
    }

    public FloatKeyData(float value )  : base() 
    {
        this.Value = value;
    }

    public static FloatKeyData DeserializeFloatKeyData(JsonElement _json)
    {
        return new ai.FloatKeyData(_json);
    }

    public float Value { get; private set; }

    public const int ID = -719747885;
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
        + "Value:" + Value + ","
        + "}";
    }
    }
}
