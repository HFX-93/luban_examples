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



namespace editor.cfg.error
{

public sealed partial class ErrorStyleDlgOk :  error.ErrorStyle 
{
    public ErrorStyleDlgOk()
    {
            BtnName = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["btn_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  BtnName = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {

            if (BtnName == null) { throw new System.ArgumentNullException(); }
            _json["btn_name"] = new JSONString(BtnName);
        }
    }

    public static ErrorStyleDlgOk LoadJsonErrorStyleDlgOk(SimpleJSON.JSONNode _json)
    {
        ErrorStyleDlgOk obj = new error.ErrorStyleDlgOk();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonErrorStyleDlgOk(ErrorStyleDlgOk _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string BtnName { get; set; }

}
}
