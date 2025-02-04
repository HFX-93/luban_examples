//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.test
{

public sealed partial class TestSep :  Bright.Config.BeanBase 
{
    public TestSep(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X1_l10n_key = _buf.ReadString(); X1 = _buf.ReadString();
        X2 = test.SepBean1.DeserializeSepBean1(_buf);
        X3 = test.SepVector.DeserializeSepVector(_buf);
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X4 = new System.Collections.Generic.List<test.SepVector>(n);for(var i = 0 ; i < n ; i++) { test.SepVector _e;  _e = test.SepVector.DeserializeSepVector(_buf); X4.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X5 = new System.Collections.Generic.List<test.SepBean1>(n);for(var i = 0 ; i < n ; i++) { test.SepBean1 _e;  _e = test.SepBean1.DeserializeSepBean1(_buf); X5.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X6 = new System.Collections.Generic.List<test.SepBean1>(n);for(var i = 0 ; i < n ; i++) { test.SepBean1 _e;  _e = test.SepBean1.DeserializeSepBean1(_buf); X6.Add(_e);}}
        PostInit();
    }

    public static TestSep DeserializeTestSep(ByteBuf _buf)
    {
        return new test.TestSep(_buf);
    }

    public int Id { get; protected set; }
    public string X1 { get; protected set; }
    //field.gen_text_key
    public string X1_l10n_key { get; protected set; }
    public test.SepBean1 X2 { get; protected set; }
    /// <summary>
    /// SepVector已经定义了sep=,属性
    /// </summary>
    public test.SepVector X3 { get; protected set; }
    /// <summary>
    /// 用;来分割数据，然后顺序读入SepVector
    /// </summary>
    public System.Collections.Generic.List<test.SepVector> X4 { get; protected set; }
    /// <summary>
    /// 用,分割数据，然后顺序读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X5 { get; protected set; }
    /// <summary>
    /// 用;分割数据，然后再将每个数据用,分割，读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X6 { get; protected set; }

    public const int __ID__ = -543221520;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X2?.Resolve(_tables);
        X3?.Resolve(_tables);
        foreach(var _e in X4) { _e?.Resolve(_tables); }
        foreach(var _e in X5) { _e?.Resolve(_tables); }
        foreach(var _e in X6) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X1 = translator(X1_l10n_key, X1);
        X2?.TranslateText(translator);
        X3?.TranslateText(translator);
        foreach(var _e in X4) { _e?.TranslateText(translator); }
        foreach(var _e in X5) { _e?.TranslateText(translator); }
        foreach(var _e in X6) { _e?.TranslateText(translator); }
    }

    public void Reload(TestSep reloadData)
    {
        Id = reloadData.Id;
        X1 = reloadData.X1;
        if(X2==null)
        {
            X2 = reloadData.X2;
        }else
        {
            if(X2.GetTypeId() == reloadData.X2.GetTypeId())
            {
                X2.Reload(reloadData.X2);
            }else
            {
                typeof(TestSep).GetProperty("X2").SetValue(this,reloadData.X2);
            }
        }
        if(X3==null)
        {
            X3 = reloadData.X3;
        }else
        {
            if(X3.GetTypeId() == reloadData.X3.GetTypeId())
            {
                X3.Reload(reloadData.X3);
            }else
            {
                typeof(TestSep).GetProperty("X3").SetValue(this,reloadData.X3);
            }
        }
        if(X4==null)
        {
            X4 = reloadData.X4;
        }else
        {
            X4.Capacity = reloadData.X4.Count;
            for (int i = 0; i < reloadData.X4.Count; i++)
            {
                if(X4[i]!=null)
                {
                    X4[i].Reload(reloadData.X4[i]);
                }else
                {
                    X4[i] = reloadData.X4[i];
                }
            }
        }
        if(X5==null)
        {
            X5 = reloadData.X5;
        }else
        {
            X5.Capacity = reloadData.X5.Count;
            for (int i = 0; i < reloadData.X5.Count; i++)
            {
                if(X5[i]!=null)
                {
                    X5[i].Reload(reloadData.X5[i]);
                }else
                {
                    X5[i] = reloadData.X5[i];
                }
            }
        }
        if(X6==null)
        {
            X6 = reloadData.X6;
        }else
        {
            X6.Capacity = reloadData.X6.Count;
            for (int i = 0; i < reloadData.X6.Count; i++)
            {
                if(X6[i]!=null)
                {
                    X6[i].Reload(reloadData.X6[i]);
                }else
                {
                    X6[i] = reloadData.X6[i];
                }
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + Bright.Common.StringUtil.CollectionToString(X4) + ","
        + "X5:" + Bright.Common.StringUtil.CollectionToString(X5) + ","
        + "X6:" + Bright.Common.StringUtil.CollectionToString(X6) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
