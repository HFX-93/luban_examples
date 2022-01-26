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

public sealed partial class ProbabilityItemInfo :  Bright.Config.EditorBeanBase 
{
    public ProbabilityItemInfo()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["item_id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  ItemId = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["num"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Num = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["probability"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Probability = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["item_id"] = new JSONNumber(ItemId);
        }
        {
            _json["num"] = new JSONNumber(Num);
        }
        {
            _json["probability"] = new JSONNumber(Probability);
        }
    }

    public static ProbabilityItemInfo LoadJsonProbabilityItemInfo(SimpleJSON.JSONNode _json)
    {
        ProbabilityItemInfo obj = new bonus.ProbabilityItemInfo();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonProbabilityItemInfo(ProbabilityItemInfo _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int ItemId { get; set; }

    public int Num { get; set; }

    public float Probability { get; set; }

}
}
