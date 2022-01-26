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

public abstract partial class Node :  Bright.Config.EditorBeanBase 
{
    public Node()
    {
            NodeName = "";
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
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  NodeName = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (NodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(NodeName);
        }
    }

    public static Node LoadJsonNode(SimpleJSON.JSONNode _json)
    {
        string type = _json["__type__"];
        Node obj;
        switch (type)
        {
            case "UeSetDefaultFocus": obj = new ai.UeSetDefaultFocus(); break;
            case "ExecuteTimeStatistic": obj = new ai.ExecuteTimeStatistic(); break;
            case "ChooseTarget": obj = new ai.ChooseTarget(); break;
            case "KeepFaceTarget": obj = new ai.KeepFaceTarget(); break;
            case "GetOwnerPlayer": obj = new ai.GetOwnerPlayer(); break;
            case "UpdateDailyBehaviorProps": obj = new ai.UpdateDailyBehaviorProps(); break;
            case "UeLoop": obj = new ai.UeLoop(); break;
            case "UeCooldown": obj = new ai.UeCooldown(); break;
            case "UeTimeLimit": obj = new ai.UeTimeLimit(); break;
            case "UeBlackboard": obj = new ai.UeBlackboard(); break;
            case "UeForceSuccess": obj = new ai.UeForceSuccess(); break;
            case "IsAtLocation": obj = new ai.IsAtLocation(); break;
            case "DistanceLessThan": obj = new ai.DistanceLessThan(); break;
            case "Sequence": obj = new ai.Sequence(); break;
            case "Selector": obj = new ai.Selector(); break;
            case "SimpleParallel": obj = new ai.SimpleParallel(); break;
            case "UeWait": obj = new ai.UeWait(); break;
            case "UeWaitBlackboardTime": obj = new ai.UeWaitBlackboardTime(); break;
            case "MoveToTarget": obj = new ai.MoveToTarget(); break;
            case "ChooseSkill": obj = new ai.ChooseSkill(); break;
            case "MoveToRandomLocation": obj = new ai.MoveToRandomLocation(); break;
            case "MoveToLocation": obj = new ai.MoveToLocation(); break;
            case "DebugPrint": obj = new ai.DebugPrint(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonNode(Node _obj, SimpleJSON.JSONNode _json)
    {
        _json["__type__"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public string NodeName { get; set; }

}
}
