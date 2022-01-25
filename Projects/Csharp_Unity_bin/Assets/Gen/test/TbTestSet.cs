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
   
public sealed class TbTestSet
{
    private readonly Dictionary<int, test.TestSet> _dataMap;
    private readonly List<test.TestSet> _dataList;
    
    public TbTestSet(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.TestSet>();
        _dataList = new List<test.TestSet>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.TestSet _v;
            _v = test.TestSet.DeserializeTestSet(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, test.TestSet> DataMap => _dataMap;
    public List<test.TestSet> DataList => _dataList;

    public test.TestSet GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestSet Get(int key) => _dataMap[key];
    public test.TestSet this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
}

}