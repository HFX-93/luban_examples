
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "bright/serialization"
)

import "errors"

type AiService struct {
    Id int32
    NodeName string
}

const TypeId_AiService = -472395057

func (*AiService) GetTypeId() int32 {
    return -472395057
}

func (_v *AiService)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiService)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("_v.NodeName error"); return } }
    return
}

func DeserializeAiService(_buf *serialization.ByteBuf) (interface{}, error) {
    var id int32
    var err error
    if id, err = _buf.ReadInt() ; err != nil {
        return nil, err
    }
    switch id {
        case 1812449155: _v := &AiUeSetDefaultFocus{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeSetDefaultFocus") } else { return _v, nil }
        case 990693812: _v := &AiExecuteTimeStatistic{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.ExecuteTimeStatistic") } else { return _v, nil }
        case 1601247918: _v := &AiChooseTarget{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.ChooseTarget") } else { return _v, nil }
        case 1195270745: _v := &AiKeepFaceTarget{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.KeepFaceTarget") } else { return _v, nil }
        case -999247644: _v := &AiGetOwnerPlayer{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.GetOwnerPlayer") } else { return _v, nil }
        case -61887372: _v := &AiUpdateDailyBehaviorProps{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UpdateDailyBehaviorProps") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}

