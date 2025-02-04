
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

public sealed class TestDesc :  Bright.Config.BeanBase 
{
    public TestDesc(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        A1 = _buf.ReadInt();
        A2 = _buf.ReadInt();
        X1 = test.H1.DeserializeH1(_buf);
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X2 = new System.Collections.Generic.List<test.H2>(n);for(var i = 0 ; i < n ; i++) { test.H2 _e;  _e = test.H2.DeserializeH2(_buf); X2.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X3 = new test.H2[n];for(var i = 0 ; i < n ; i++) { test.H2 _e;_e = test.H2.DeserializeH2(_buf); X3[i] = _e;}}
    }

    public static TestDesc DeserializeTestDesc(ByteBuf _buf)
    {
        return new test.TestDesc(_buf);
    }

    public int Id { get; private set; }
    /// <summary>
    /// 禁止
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 测试换行<br/>第2行<br/>第3层
    /// </summary>
    public int A1 { get; private set; }
    /// <summary>
    /// 测试转义 &lt; &amp; % / # &gt;
    /// </summary>
    public int A2 { get; private set; }
    public test.H1 X1 { get; private set; }
    /// <summary>
    /// 这是x2
    /// </summary>
    public System.Collections.Generic.List<test.H2> X2 { get; private set; }
    public test.H2[] X3 { get; private set; }

    public const int __ID__ = 339555391;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X1?.Resolve(_tables);
        foreach(var _e in X2) { _e?.Resolve(_tables); }
        foreach(var _e in X3) { _e?.Resolve(_tables); }
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X1?.TranslateText(translator);
        foreach(var _e in X2) { _e?.TranslateText(translator); }
        foreach(var _e in X3) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "A1:" + A1 + ","
        + "A2:" + A2 + ","
        + "X1:" + X1 + ","
        + "X2:" + Bright.Common.StringUtil.CollectionToString(X2) + ","
        + "X3:" + Bright.Common.StringUtil.CollectionToString(X3) + ","
        + "}";
    }
    }

}
