//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.ai
{

public sealed partial class Sequence :  ai.ComposeNode 
{
    public Sequence(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Children = new System.Collections.Generic.List<ai.FlowNode>(n);for(var i = 0 ; i < n ; i++) { ai.FlowNode _e;  _e = ai.FlowNode.DeserializeFlowNode(_buf); Children.Add(_e);}}
        PostInit();
    }

    public static Sequence DeserializeSequence(ByteBuf _buf)
    {
        return new ai.Sequence(_buf);
    }

    public System.Collections.Generic.List<ai.FlowNode> Children { get; protected set; }

    public const int __ID__ = -1789006105;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Children) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Children) { _e?.TranslateText(translator); }
    }

    public void Reload(Sequence reloadData)
    {
        Id = reloadData.Id;
        NodeName = reloadData.NodeName;
        if(Decorators==null)
        {
            Decorators = reloadData.Decorators;
        }else
        {
            Decorators.Capacity = reloadData.Decorators.Count;
            for (int i = 0; i < reloadData.Decorators.Count; i++)
            {
                if(Decorators[i]!=null && Decorators[i].GetTypeId() == reloadData.Decorators[i].GetTypeId())
                {
                    switch (reloadData.Decorators[i].GetTypeId())
                    {
                        case ai.UeLoop.__ID__:
                            (Decorators[i] as ai.UeLoop).Reload(reloadData.Decorators[i] as ai.UeLoop);
                            break;
                        case ai.UeCooldown.__ID__:
                            (Decorators[i] as ai.UeCooldown).Reload(reloadData.Decorators[i] as ai.UeCooldown);
                            break;
                        case ai.UeTimeLimit.__ID__:
                            (Decorators[i] as ai.UeTimeLimit).Reload(reloadData.Decorators[i] as ai.UeTimeLimit);
                            break;
                        case ai.UeBlackboard.__ID__:
                            (Decorators[i] as ai.UeBlackboard).Reload(reloadData.Decorators[i] as ai.UeBlackboard);
                            break;
                        case ai.UeForceSuccess.__ID__:
                            (Decorators[i] as ai.UeForceSuccess).Reload(reloadData.Decorators[i] as ai.UeForceSuccess);
                            break;
                        case ai.IsAtLocation.__ID__:
                            (Decorators[i] as ai.IsAtLocation).Reload(reloadData.Decorators[i] as ai.IsAtLocation);
                            break;
                        case ai.DistanceLessThan.__ID__:
                            (Decorators[i] as ai.DistanceLessThan).Reload(reloadData.Decorators[i] as ai.DistanceLessThan);
                            break;
                    }
                }else
                {
                    Decorators[i] = reloadData.Decorators[i];
                }
            }
        }
        if(Services==null)
        {
            Services = reloadData.Services;
        }else
        {
            Services.Capacity = reloadData.Services.Count;
            for (int i = 0; i < reloadData.Services.Count; i++)
            {
                if(Services[i]!=null && Services[i].GetTypeId() == reloadData.Services[i].GetTypeId())
                {
                    switch (reloadData.Services[i].GetTypeId())
                    {
                        case ai.UeSetDefaultFocus.__ID__:
                            (Services[i] as ai.UeSetDefaultFocus).Reload(reloadData.Services[i] as ai.UeSetDefaultFocus);
                            break;
                        case ai.ExecuteTimeStatistic.__ID__:
                            (Services[i] as ai.ExecuteTimeStatistic).Reload(reloadData.Services[i] as ai.ExecuteTimeStatistic);
                            break;
                        case ai.ChooseTarget.__ID__:
                            (Services[i] as ai.ChooseTarget).Reload(reloadData.Services[i] as ai.ChooseTarget);
                            break;
                        case ai.KeepFaceTarget.__ID__:
                            (Services[i] as ai.KeepFaceTarget).Reload(reloadData.Services[i] as ai.KeepFaceTarget);
                            break;
                        case ai.GetOwnerPlayer.__ID__:
                            (Services[i] as ai.GetOwnerPlayer).Reload(reloadData.Services[i] as ai.GetOwnerPlayer);
                            break;
                        case ai.UpdateDailyBehaviorProps.__ID__:
                            (Services[i] as ai.UpdateDailyBehaviorProps).Reload(reloadData.Services[i] as ai.UpdateDailyBehaviorProps);
                            break;
                    }
                }else
                {
                    Services[i] = reloadData.Services[i];
                }
            }
        }
        if(Children==null)
        {
            Children = reloadData.Children;
        }else
        {
            Children.Capacity = reloadData.Children.Count;
            for (int i = 0; i < reloadData.Children.Count; i++)
            {
                if(Children[i]!=null && Children[i].GetTypeId() == reloadData.Children[i].GetTypeId())
                {
                    switch (reloadData.Children[i].GetTypeId())
                    {
                        case ai.Sequence.__ID__:
                            (Children[i] as ai.Sequence).Reload(reloadData.Children[i] as ai.Sequence);
                            break;
                        case ai.Selector.__ID__:
                            (Children[i] as ai.Selector).Reload(reloadData.Children[i] as ai.Selector);
                            break;
                        case ai.SimpleParallel.__ID__:
                            (Children[i] as ai.SimpleParallel).Reload(reloadData.Children[i] as ai.SimpleParallel);
                            break;
                        case ai.UeWait.__ID__:
                            (Children[i] as ai.UeWait).Reload(reloadData.Children[i] as ai.UeWait);
                            break;
                        case ai.UeWaitBlackboardTime.__ID__:
                            (Children[i] as ai.UeWaitBlackboardTime).Reload(reloadData.Children[i] as ai.UeWaitBlackboardTime);
                            break;
                        case ai.MoveToTarget.__ID__:
                            (Children[i] as ai.MoveToTarget).Reload(reloadData.Children[i] as ai.MoveToTarget);
                            break;
                        case ai.ChooseSkill.__ID__:
                            (Children[i] as ai.ChooseSkill).Reload(reloadData.Children[i] as ai.ChooseSkill);
                            break;
                        case ai.MoveToRandomLocation.__ID__:
                            (Children[i] as ai.MoveToRandomLocation).Reload(reloadData.Children[i] as ai.MoveToRandomLocation);
                            break;
                        case ai.MoveToLocation.__ID__:
                            (Children[i] as ai.MoveToLocation).Reload(reloadData.Children[i] as ai.MoveToLocation);
                            break;
                        case ai.DebugPrint.__ID__:
                            (Children[i] as ai.DebugPrint).Reload(reloadData.Children[i] as ai.DebugPrint);
                            break;
                    }
                }else
                {
                    Children[i] = reloadData.Children[i];
                }
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "Children:" + Bright.Common.StringUtil.CollectionToString(Children) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
