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



namespace editor.cfg.test
{

public sealed partial class MultiRowType2 :  Bright.Config.EditorBeanBase 
{
    public MultiRowType2()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  X = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["y"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Y = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["id"] = new JSONNumber(Id);
        }
        {
            _json["x"] = new JSONNumber(X);
        }
        {
            _json["y"] = new JSONNumber(Y);
        }
    }

    public static MultiRowType2 LoadJsonMultiRowType2(SimpleJSON.JSONNode _json)
    {
        MultiRowType2 obj = new test.MultiRowType2();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMultiRowType2(MultiRowType2 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public int X { get; set; }

    public float Y { get; set; }

}
}
