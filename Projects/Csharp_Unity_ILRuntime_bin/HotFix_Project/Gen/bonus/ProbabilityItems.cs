
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

public sealed class ProbabilityItems :  bonus.Bonus 
{
    public ProbabilityItems(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ItemList = new bonus.ProbabilityItemInfo[n];for(var i = 0 ; i < n ; i++) { bonus.ProbabilityItemInfo _e;_e = bonus.ProbabilityItemInfo.DeserializeProbabilityItemInfo(_buf); ItemList[i] = _e;}}
    }

    public static ProbabilityItems DeserializeProbabilityItems(ByteBuf _buf)
    {
        return new bonus.ProbabilityItems(_buf);
    }

    public bonus.ProbabilityItemInfo[] ItemList { get; private set; }

    public const int __ID__ = 366387866;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in ItemList) { _e?.Resolve(_tables); }
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in ItemList) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "ItemList:" + Bright.Common.StringUtil.CollectionToString(ItemList) + ","
        + "}";
    }
    }

}
