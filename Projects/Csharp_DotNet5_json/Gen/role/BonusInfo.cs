
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



namespace cfg.role
{

public sealed class BonusInfo :  Bright.Config.BeanBase 
{
    public BonusInfo(JsonElement _json) 
    {
        Type = (item.ECurrencyType)_json.GetProperty("type").GetInt32();
        Coefficient = _json.GetProperty("coefficient").GetSingle();
    }

    public BonusInfo(item.ECurrencyType type, float coefficient ) 
    {
        this.Type = type;
        this.Coefficient = coefficient;
    }

    public static BonusInfo DeserializeBonusInfo(JsonElement _json)
    {
        return new role.BonusInfo(_json);
    }

    public item.ECurrencyType Type { get; private set; }
    public float Coefficient { get; private set; }

    public const int ID = -1354421803;
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
        + "Type:" + Type + ","
        + "Coefficient:" + Coefficient + ","
        + "}";
    }
    }
}
