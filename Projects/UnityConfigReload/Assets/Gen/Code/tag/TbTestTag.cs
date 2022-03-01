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

namespace cfg.tag
{
   
public partial class TbTestTag
{
    private Dictionary<int, tag.TestTag> _dataMap;
    private List<tag.TestTag> _dataList;
    
    public TbTestTag(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, tag.TestTag>();
        _dataList = new List<tag.TestTag>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            tag.TestTag _v;
            _v = tag.TestTag.DeserializeTestTag(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, tag.TestTag> DataMap => _dataMap;
    public List<tag.TestTag> DataList => _dataList;

    public tag.TestTag GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public tag.TestTag Get(int key) => _dataMap[key];
    public tag.TestTag this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }

    public void Reload(ByteBuf _buf)
    {
        var reloadMap = new TbTestTag(_buf);
        foreach (var rowDataKey in this._dataMap.Keys.ToList())
        {
            if(!reloadMap._dataMap.ContainsKey(rowDataKey))
            {
                this._dataList.Remove(this._dataMap[rowDataKey]);
                this._dataMap.Remove(rowDataKey);
            }
        }

        foreach (var reloadData in reloadMap._dataMap)
        {
            if (this._dataMap.ContainsKey(reloadData.Key))
            {
                this._dataMap[reloadData.Key].Reload(reloadData.Value);
            }
            else
            {
                this._dataMap.Add(reloadData.Key,reloadData.Value);
                this._dataList.Add(reloadData.Value);
            }
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}