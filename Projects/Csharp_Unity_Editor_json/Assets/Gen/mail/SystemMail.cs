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



namespace editor.cfg.mail
{

public sealed partial class SystemMail :  Bright.Config.EditorBeanBase 
{
    public SystemMail()
    {
            Title = "";
            Sender = "";
            Content = "";
            Award = new System.Collections.Generic.List<int>();
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
            var _fieldJson = _json["title"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Title = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["sender"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Sender = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["content"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  Content = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["award"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } Award = new System.Collections.Generic.List<int>(); foreach(JSONNode __e in _fieldJson.Children) { int __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  Award.Add(__v); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (Title == null) { throw new System.ArgumentNullException(); }
            _json["title"] = new JSONString(Title);
        }
        {

            if (Sender == null) { throw new System.ArgumentNullException(); }
            _json["sender"] = new JSONString(Sender);
        }
        {

            if (Content == null) { throw new System.ArgumentNullException(); }
            _json["content"] = new JSONString(Content);
        }
        {

            if (Award == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in Award) { __cjson["null"] = new JSONNumber(_e); } _json["award"] = __cjson; }
        }
    }

    public static SystemMail LoadJsonSystemMail(SimpleJSON.JSONNode _json)
    {
        SystemMail obj = new mail.SystemMail();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonSystemMail(SystemMail _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public string Sender { get; set; }

    public string Content { get; set; }

    public System.Collections.Generic.List<int> Award { get; set; }

}
}
