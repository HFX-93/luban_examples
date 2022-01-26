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

public sealed partial class TestSep :  Bright.Config.EditorBeanBase 
{
    public TestSep()
    {
            X1 = new Bright.Config.EditorText("", "");
            X2 = new test.SepBean1();
            X3 = new test.SepVector();
            X4 = new System.Collections.Generic.List<test.SepVector>();
            X5 = new System.Collections.Generic.List<test.SepBean1>();
            X6 = new System.Collections.Generic.List<test.SepBean1>();
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
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                X1 = Bright.Config.EditorText.LoadJson(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  X2 = test.SepBean1.LoadJsonSepBean1(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  X3 = test.SepVector.LoadJsonSepVector(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } X4 = new System.Collections.Generic.List<test.SepVector>(); foreach(JSONNode __e in _fieldJson.Children) { test.SepVector __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = test.SepVector.LoadJsonSepVector(__e);  X4.Add(__v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x5"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } X5 = new System.Collections.Generic.List<test.SepBean1>(); foreach(JSONNode __e in _fieldJson.Children) { test.SepBean1 __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = test.SepBean1.LoadJsonSepBean1(__e);  X5.Add(__v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x6"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } X6 = new System.Collections.Generic.List<test.SepBean1>(); foreach(JSONNode __e in _fieldJson.Children) { test.SepBean1 __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = test.SepBean1.LoadJsonSepBean1(__e);  X6.Add(__v); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (X1 == null) { throw new System.ArgumentNullException(); }
            _json["x1"] = Bright.Config.EditorText.SaveJson(X1);
        }
        {

            if (X2 == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  test.SepBean1.SaveJsonSepBean1(X2, __bjson); _json["x2"] = __bjson; }
        }
        {

            if (X3 == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  test.SepVector.SaveJsonSepVector(X3, __bjson); _json["x3"] = __bjson; }
        }
        {

            if (X4 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in X4) { { var __bjson = new JSONObject();  test.SepVector.SaveJsonSepVector(_e, __bjson); __cjson["null"] = __bjson; } } _json["x4"] = __cjson; }
        }
        {

            if (X5 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in X5) { { var __bjson = new JSONObject();  test.SepBean1.SaveJsonSepBean1(_e, __bjson); __cjson["null"] = __bjson; } } _json["x5"] = __cjson; }
        }
        {

            if (X6 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in X6) { { var __bjson = new JSONObject();  test.SepBean1.SaveJsonSepBean1(_e, __bjson); __cjson["null"] = __bjson; } } _json["x6"] = __cjson; }
        }
    }

    public static TestSep LoadJsonTestSep(SimpleJSON.JSONNode _json)
    {
        TestSep obj = new test.TestSep();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestSep(TestSep _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public Bright.Config.EditorText X1 { get; set; }

    public test.SepBean1 X2 { get; set; }

    /// <summary>
    /// SepVector已经定义了sep=,属性
    /// </summary>
    public test.SepVector X3 { get; set; }

    /// <summary>
    /// 用;来分割数据，然后顺序读入SepVector
    /// </summary>
    public System.Collections.Generic.List<test.SepVector> X4 { get; set; }

    /// <summary>
    /// 用,分割数据，然后顺序读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X5 { get; set; }

    /// <summary>
    /// 用;分割数据，然后再将每个数据用,分割，读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X6 { get; set; }

}
}
