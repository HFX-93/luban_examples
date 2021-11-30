
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiFlowNode struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
}

const TypeId_AiFlowNode = -1109240970

func (*AiFlowNode) GetTypeId() int32 {
    return -1109240970
}

func (_v *AiFlowNode)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.NodeName, _ok_ = _buf["node_name"].(string); !_ok_ { err = errors.New("node_name error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["decorators"].([]interface{}); !_ok_ { err = errors.New("decorators error"); return }

                _v.Decorators = make([]interface{}, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ interface{}
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeAiDecorator(_x_); err != nil { return } }
                    _v.Decorators = append(_v.Decorators, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["services"].([]interface{}); !_ok_ { err = errors.New("services error"); return }

                _v.Services = make([]interface{}, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ interface{}
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeAiService(_x_); err != nil { return } }
                    _v.Services = append(_v.Services, _list_v_)
                }
            }

    return
}

func DeserializeAiFlowNode(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "Sequence": _v := &AiSequence{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.Sequence") } else { return _v, nil }
        case "Selector": _v := &AiSelector{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.Selector") } else { return _v, nil }
        case "SimpleParallel": _v := &AiSimpleParallel{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.SimpleParallel") } else { return _v, nil }
        case "UeWait": _v := &AiUeWait{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeWait") } else { return _v, nil }
        case "UeWaitBlackboardTime": _v := &AiUeWaitBlackboardTime{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeWaitBlackboardTime") } else { return _v, nil }
        case "MoveToTarget": _v := &AiMoveToTarget{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.MoveToTarget") } else { return _v, nil }
        case "ChooseSkill": _v := &AiChooseSkill{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.ChooseSkill") } else { return _v, nil }
        case "MoveToRandomLocation": _v := &AiMoveToRandomLocation{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.MoveToRandomLocation") } else { return _v, nil }
        case "MoveToLocation": _v := &AiMoveToLocation{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.MoveToLocation") } else { return _v, nil }
        case "DebugPrint": _v := &AiDebugPrint{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.DebugPrint") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}
