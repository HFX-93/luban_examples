
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



namespace cfg.error
{

public sealed class ErrorStyleDlgOk :  error.ErrorStyle 
{
    public ErrorStyleDlgOk(JsonElement _json)  : base(_json) 
    {
        BtnName = _json.GetProperty("btn_name").GetString();
    }

    public ErrorStyleDlgOk(string btn_name )  : base() 
    {
        this.BtnName = btn_name;
    }

    public static ErrorStyleDlgOk DeserializeErrorStyleDlgOk(JsonElement _json)
    {
        return new error.ErrorStyleDlgOk(_json);
    }

    public string BtnName { get; private set; }

    public const int ID = -2010134516;
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
        + "BtnName:" + BtnName + ","
        + "}";
    }
    }
}
