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



namespace editor.cfg.ai
{

public sealed partial class IsAtLocation :  ai.Decorator 
{
    public IsAtLocation()
    {
            KeyboardKey = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["acceptable_radius"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  AcceptableRadius = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["keyboard_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  KeyboardKey = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["inverse_condition"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  InverseCondition = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            _json["acceptable_radius"] = new JSONNumber(AcceptableRadius);
        }
        {

            if (KeyboardKey == null) { throw new System.ArgumentNullException(); }
            _json["keyboard_key"] = new JSONString(KeyboardKey);
        }
        {
            _json["inverse_condition"] = new JSONBool(InverseCondition);
        }
    }

    public static IsAtLocation LoadJsonIsAtLocation(SimpleJSON.JSONNode _json)
    {
        IsAtLocation obj = new ai.IsAtLocation();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonIsAtLocation(IsAtLocation _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public float AcceptableRadius { get; set; }

    public string KeyboardKey { get; set; }

    public bool InverseCondition { get; set; }

}
}
