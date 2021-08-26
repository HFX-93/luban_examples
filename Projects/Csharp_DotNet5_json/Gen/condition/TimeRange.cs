
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

public sealed class TimeRange :  condition.Condition 
{
    public TimeRange(JsonElement _json)  : base(_json) 
    {
        DateTimeRange =  common.DateTimeRange.DeserializeDateTimeRange(_json.GetProperty("date_time_range"));
    }

    public TimeRange(common.DateTimeRange date_time_range )  : base() 
    {
        this.DateTimeRange = date_time_range;
    }

    public static TimeRange DeserializeTimeRange(JsonElement _json)
    {
        return new condition.TimeRange(_json);
    }

    public common.DateTimeRange DateTimeRange { get; private set; }

    public const int ID = 1069033789;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        DateTimeRange?.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        DateTimeRange?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "DateTimeRange:" + DateTimeRange + ","
        + "}";
    }
    }
}
