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

public abstract partial class Method :  Bright.Config.EditorBeanBase 
{
    public Method()
    {
            Name = "";
            Desc = "";
            ReturnType = "";
            Parameters = new System.Collections.Generic.List<blueprint.ParamInfo>();
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
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Desc = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["is_static"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  IsStatic = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["return_type"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  ReturnType = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["parameters"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } Parameters = new System.Collections.Generic.List<blueprint.ParamInfo>(); foreach(JSONNode __e in _fieldJson.Children) { blueprint.ParamInfo __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = blueprint.ParamInfo.LoadJsonParamInfo(__e);  Parameters.Add(__v); }  
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

            if (Desc == null) { throw new System.ArgumentNullException(); }
            _json["desc"] = new JSONString(Desc);
        }
        {
            _json["is_static"] = new JSONBool(IsStatic);
        }
        {

            if (ReturnType == null) { throw new System.ArgumentNullException(); }
            _json["return_type"] = new JSONString(ReturnType);
        }
        {

            if (Parameters == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in Parameters) { { var __bjson = new JSONObject();  blueprint.ParamInfo.SaveJsonParamInfo(_e, __bjson); __cjson["null"] = __bjson; } } _json["parameters"] = __cjson; }
        }
    }

    public static Method LoadJsonMethod(SimpleJSON.JSONNode _json)
    {
        string type = _json["__type__"];
        Method obj;
        switch (type)
        {
            case "AbstraceMethod": obj = new blueprint.AbstraceMethod(); break;
            case "ExternalMethod": obj = new blueprint.ExternalMethod(); break;
            case "BlueprintMethod": obj = new blueprint.BlueprintMethod(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMethod(Method _obj, SimpleJSON.JSONNode _json)
    {
        _json["__type__"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string Name { get; set; }

    public string Desc { get; set; }

    public bool IsStatic { get; set; }

    public string ReturnType { get; set; }

    public System.Collections.Generic.List<blueprint.ParamInfo> Parameters { get; set; }

}
}
