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

public sealed partial class TestRow :  Bright.Config.BeanBase 
{
    public TestRow(ByteBuf _buf) 
    {
        X = _buf.ReadInt();
        Y = _buf.ReadBool();
        Z = _buf.ReadString();
        A = test.Test3.DeserializeTest3(_buf);
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);B = new System.Collections.Generic.List<int>(n);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); B.Add(_e);}}
        PostInit();
    }

    public static TestRow DeserializeTestRow(ByteBuf _buf)
    {
        return new test.TestRow(_buf);
    }

    public int X { get; protected set; }
    public bool Y { get; protected set; }
    public string Z { get; protected set; }
    public test.Test3 A { get; protected set; }
    public System.Collections.Generic.List<int> B { get; protected set; }

    public const int __ID__ = -543222164;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        A?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        A?.TranslateText(translator);
    }

    public void Reload(TestRow reloadData)
    {
        X = reloadData.X;
        Y = reloadData.Y;
        Z = reloadData.Z;
        if(A==null)
        {
            A = reloadData.A;
        }else
        {
            if(A.GetTypeId() == reloadData.A.GetTypeId())
            {
                A.Reload(reloadData.A);
            }else
            {
                typeof(TestRow).GetProperty("A").SetValue(this,reloadData.A);
            }
        }
        if(B==null)
        {
            B = reloadData.B;
        }else
        {
            B.Capacity = reloadData.B.Count;
            for (int i = 0; i < reloadData.B.Count; i++)
            {
                B[i] = reloadData.B[i];
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "X:" + X + ","
        + "Y:" + Y + ","
        + "Z:" + Z + ","
        + "A:" + A + ","
        + "B:" + Bright.Common.StringUtil.CollectionToString(B) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
