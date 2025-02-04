using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;

{{ 
    name = x.name
    key_type = x.key_ttype
    key_type1 =  x.key_ttype1
    key_type2 =  x.key_ttype2
    value_type =  x.value_ttype
}}

namespace {{x.namespace_with_top_module}}
{

{{~if x.comment != '' ~}}
/// <summary>
/// {{x.comment}}
/// </summary>
{{~end~}}
public sealed class {{name}}
{
    {{~if x.is_map_table ~}}
    private readonly Dictionary<{{cs_define_type key_type}}, {{cs_define_type value_type}}> _dataMap;
    private readonly List<{{cs_define_type value_type}}> _dataList;
    
    public {{name}}(JsonElement _json)
    {
        _dataMap = new Dictionary<{{cs_define_type key_type}}, {{cs_define_type value_type}}>();
        _dataList = new List<{{cs_define_type value_type}}>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = {{cs_define_type value_type}}.Deserialize{{value_type.bean.name}}(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.{{x.index_field.cs_style_name}}, _v);
        }
    }

    public Dictionary<{{cs_define_type key_type}}, {{cs_define_type value_type}}> DataMap => _dataMap;
    public List<{{cs_define_type value_type}}> DataList => _dataList;

{{~if value_type.is_dynamic~}}
    public T GetOrDefaultAs<T>({{cs_define_type key_type}} key) where T : {{cs_define_type value_type}} => _dataMap.TryGetValue(key, out var v) ? (T)v : null;
    public T GetAs<T>({{cs_define_type key_type}} key) where T : {{cs_define_type value_type}} => (T)_dataMap[key];
{{~end~}}
    public {{cs_define_type value_type}} GetOrDefault({{cs_define_type key_type}} key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public {{cs_define_type value_type}} Get({{cs_define_type key_type}} key) => _dataMap[key];
    public {{cs_define_type value_type}} this[{{cs_define_type key_type}} key] => _dataMap[key];

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

    {{~else~}}

     private readonly {{cs_define_type value_type}} _data;

    public {{name}}(JsonElement _json)
    {
        int n = _json.GetArrayLength();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = {{cs_define_type value_type}}.Deserialize{{value_type.bean.name}}(_json[0]);
    }

    {{~ for field in value_type.bean.hierarchy_export_fields ~}}
{{~if field.comment != '' ~}}
    /// <summary>
    /// {{field.comment}}
    /// </summary>
{{~end~}}
     public {{cs_define_type field.ctype}} {{field.cs_style_name}} => _data.{{field.cs_style_name}};
    {{~if field.ref~}}
        public {{field.cs_ref_type_name}} {{field.cs_ref_var_name}} => _data.{{field.cs_ref_var_name}};
    {{~end~}}
    {{~end~}}

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        _data.TranslateText(translator);
    }

    {{~end~}}
}

}