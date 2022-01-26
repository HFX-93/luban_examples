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

public sealed partial class BonusInfo :  Bright.Config.EditorBeanBase 
{
    public BonusInfo()
    {
            Type = "DIAMOND";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["type"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Type = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["coefficient"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Coefficient = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["type"] = new JSONString(Type);
        }
        {
            _json["coefficient"] = new JSONNumber(Coefficient);
        }
    }

    public static BonusInfo LoadJsonBonusInfo(SimpleJSON.JSONNode _json)
    {
        BonusInfo obj = new role.BonusInfo();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBonusInfo(BonusInfo _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string Type { get; set; }

    public float Coefficient { get; set; }

}
}
