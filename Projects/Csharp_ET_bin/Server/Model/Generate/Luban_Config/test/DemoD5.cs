
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed class DemoD5 :  test.DemoDynamic 
{
    public DemoD5(ByteBuf _buf)  : base(_buf) 
    {
        Time = test.DateTimeRange.DeserializeDateTimeRange(_buf);
    }

    public static DemoD5 DeserializeDemoD5(ByteBuf _buf)
    {
        return new test.DemoD5(_buf);
    }

    public test.DateTimeRange Time { get; private set; }

    public const int __ID__ = -2138341744;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        Time?.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        Time?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "Time:" + Time + ","
        + "}";
    }
    }

}
