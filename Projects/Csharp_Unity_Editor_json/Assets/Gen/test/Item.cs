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

public sealed partial class Item :  test.ItemBase 
{
    public Item()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["num"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Num = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["price"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Price = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            _json["num"] = new JSONNumber(Num);
        }
        {
            _json["price"] = new JSONNumber(Price);
        }
    }

    public static Item LoadJsonItem(SimpleJSON.JSONNode _json)
    {
        Item obj = new test.Item();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonItem(Item _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Num { get; set; }

    public int Price { get; set; }

}
}
