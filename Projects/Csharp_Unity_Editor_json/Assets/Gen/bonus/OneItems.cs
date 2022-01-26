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



namespace editor.cfg.bonus
{

public sealed partial class OneItems :  bonus.Bonus 
{
    public OneItems()
    {
            Items = System.Array.Empty<int>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["items"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int _n = _fieldJson.Count; Items = new int[_n]; int _index=0; foreach(SimpleJSON.JSONNode __e in _fieldJson.Children) { int __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  Items[_index++] = __v; }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {

            if (Items == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in Items) { __cjson["null"] = new JSONNumber(_e); } _json["items"] = __cjson; }
        }
    }

    public static OneItems LoadJsonOneItems(SimpleJSON.JSONNode _json)
    {
        OneItems obj = new bonus.OneItems();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonOneItems(OneItems _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int[] Items { get; set; }

}
}
