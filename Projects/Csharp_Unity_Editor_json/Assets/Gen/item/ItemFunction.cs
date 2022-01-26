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



namespace editor.cfg.item
{

public sealed partial class ItemFunction :  Bright.Config.EditorBeanBase 
{
    public ItemFunction()
    {
            MinorType = "DIAMOND";
            FuncType = "REPLACE_HANDHELD";
            Method = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["minor_type"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  MinorType = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["func_type"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  FuncType = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["method"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Method = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["close_bag_ui"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  CloseBagUi = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["minor_type"] = new JSONString(MinorType);
        }
        {
            _json["func_type"] = new JSONString(FuncType);
        }
        {

            if (Method == null) { throw new System.ArgumentNullException(); }
            _json["method"] = new JSONString(Method);
        }
        {
            _json["close_bag_ui"] = new JSONBool(CloseBagUi);
        }
    }

    public static ItemFunction LoadJsonItemFunction(SimpleJSON.JSONNode _json)
    {
        ItemFunction obj = new item.ItemFunction();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonItemFunction(ItemFunction _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string MinorType { get; set; }

    public string FuncType { get; set; }

    public string Method { get; set; }

    public bool CloseBagUi { get; set; }

}
}
