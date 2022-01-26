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



namespace editor.cfg.blueprint
{

public sealed partial class FieldValue :  Bright.Config.EditorBeanBase 
{
    public FieldValue()
    {
            Name = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Name = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["value"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  Value = blueprint.DValue.LoadJsonDValue(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {

            if (Name == null) { throw new System.ArgumentNullException(); }
            _json["name"] = new JSONString(Name);
        }
        {

            if (Value == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  blueprint.DValue.SaveJsonDValue(Value, __bjson); _json["value"] = __bjson; }
        }
    }

    public static FieldValue LoadJsonFieldValue(SimpleJSON.JSONNode _json)
    {
        FieldValue obj = new blueprint.FieldValue();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonFieldValue(FieldValue _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string Name { get; set; }

    public blueprint.DValue Value { get; set; }

}
}
