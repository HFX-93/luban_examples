
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
   
public sealed class TbTestExternalType
{
    private readonly Dictionary<int, test.TestExternalType> _dataMap;
    private readonly List<test.TestExternalType> _dataList;
    
    public TbTestExternalType(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.TestExternalType>();
        _dataList = new List<test.TestExternalType>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.TestExternalType _v;
            _v = test.TestExternalType.DeserializeTestExternalType(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, test.TestExternalType> DataMap => _dataMap;
    public List<test.TestExternalType> DataList => _dataList;

    public test.TestExternalType GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestExternalType Get(int key) => _dataMap[key];
    public test.TestExternalType this[int key] => _dataMap[key];

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