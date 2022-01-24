//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public abstract class Task :  ai.FlowNode 
{
    public Task(ByteBuf _buf)  : base(_buf) 
    {
        IgnoreRestartSelf = _buf.ReadBool();
    }

    public static Task DeserializeTask(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case ai.UeWait.__ID__: return new ai.UeWait(_buf);
            case ai.UeWaitBlackboardTime.__ID__: return new ai.UeWaitBlackboardTime(_buf);
            case ai.MoveToTarget.__ID__: return new ai.MoveToTarget(_buf);
            case ai.ChooseSkill.__ID__: return new ai.ChooseSkill(_buf);
            case ai.MoveToRandomLocation.__ID__: return new ai.MoveToRandomLocation(_buf);
            case ai.MoveToLocation.__ID__: return new ai.MoveToLocation(_buf);
            case ai.DebugPrint.__ID__: return new ai.DebugPrint(_buf);
            default: throw new SerializationException();
        }
    }

    public bool IgnoreRestartSelf { get; private set; }


    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "}";
    }
    }

}
