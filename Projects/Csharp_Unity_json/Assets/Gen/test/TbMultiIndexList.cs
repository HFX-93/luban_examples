//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.test
{

public sealed class TbMultiIndexList
{
    private readonly List<test.MultiIndexList> _dataList;
    
    private Dictionary<int, test.MultiIndexList> _dataMap_id1;
    private Dictionary<long, test.MultiIndexList> _dataMap_id2;
    private Dictionary<string, test.MultiIndexList> _dataMap_id3;

    public TbMultiIndexList(JSONNode _json)
    {
        _dataList = new List<test.MultiIndexList>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = test.MultiIndexList.DeserializeMultiIndexList(_row);
            _dataList.Add(_v);
        }
        _dataMap_id1 = new Dictionary<int, test.MultiIndexList>();
        _dataMap_id2 = new Dictionary<long, test.MultiIndexList>();
        _dataMap_id3 = new Dictionary<string, test.MultiIndexList>();
    foreach(var _v in _dataList)
    {
        _dataMap_id1.Add(_v.Id1, _v);
        _dataMap_id2.Add(_v.Id2, _v);
        _dataMap_id3.Add(_v.Id3, _v);
    }
    }

    public List<test.MultiIndexList> DataList => _dataList;

    public test.MultiIndexList GetById1(int key) => _dataMap_id1.TryGetValue(key, out test.MultiIndexList __v) ? __v : null;
    public test.MultiIndexList GetById2(long key) => _dataMap_id2.TryGetValue(key, out test.MultiIndexList __v) ? __v : null;
    public test.MultiIndexList GetById3(string key) => _dataMap_id3.TryGetValue(key, out test.MultiIndexList __v) ? __v : null;

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