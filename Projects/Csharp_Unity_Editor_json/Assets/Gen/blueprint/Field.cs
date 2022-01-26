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

public sealed partial class Field :  Bright.Config.EditorBeanBase 
{
    public Field()
    {
            Name = "";
            Type = "";
            Desc = "";
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
            var _fieldJson = _json["type"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Type = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Desc = _fieldJson;
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

            if (Type == null) { throw new System.ArgumentNullException(); }
            _json["type"] = new JSONString(Type);
        }
        {

            if (Desc == null) { throw new System.ArgumentNullException(); }
            _json["desc"] = new JSONString(Desc);
        }
    }

    public static Field LoadJsonField(SimpleJSON.JSONNode _json)
    {
        Field obj = new blueprint.Field();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonField(Field _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string Name { get; set; }

    public string Type { get; set; }

    public string Desc { get; set; }

}
}
