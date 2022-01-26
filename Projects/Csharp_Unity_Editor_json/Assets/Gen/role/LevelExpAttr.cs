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



namespace editor.cfg.role
{

public sealed partial class LevelExpAttr :  Bright.Config.EditorBeanBase 
{
    public LevelExpAttr()
    {
            ClothesAttrs = new System.Collections.Generic.List<int>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["level"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Level = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["need_exp"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  NeedExp = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["clothes_attrs"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } ClothesAttrs = new System.Collections.Generic.List<int>(); foreach(JSONNode __e in _fieldJson.Children) { int __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  ClothesAttrs.Add(__v); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["level"] = new JSONNumber(Level);
        }
        {
            _json["need_exp"] = new JSONNumber(NeedExp);
        }
        {

            if (ClothesAttrs == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in ClothesAttrs) { __cjson["null"] = new JSONNumber(_e); } _json["clothes_attrs"] = __cjson; }
        }
    }

    public static LevelExpAttr LoadJsonLevelExpAttr(SimpleJSON.JSONNode _json)
    {
        LevelExpAttr obj = new role.LevelExpAttr();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonLevelExpAttr(LevelExpAttr _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Level { get; set; }

    public long NeedExp { get; set; }

    public System.Collections.Generic.List<int> ClothesAttrs { get; set; }

}
}
