
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

type ConditionRoleCondition struct {
}

const TypeId_ConditionRoleCondition = -1632338542

func (*ConditionRoleCondition) GetTypeId() int32 {
    return -1632338542
}

func (_v *ConditionRoleCondition)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *ConditionRoleCondition)Deserialize(_buf *serialization.ByteBuf) (err error) {
    return
}

func DeserializeConditionRoleCondition(_buf *serialization.ByteBuf) (interface{}, error) {
    var id int32
    var err error
    if id, err = _buf.ReadInt() ; err != nil {
        return nil, err
    }
    switch id {
        case 934079583: _v := &ConditionMultiRoleCondition{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("condition.MultiRoleCondition") } else { return _v, nil }
        case 103675143: _v := &ConditionGenderLimit{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("condition.GenderLimit") } else { return _v, nil }
        case -1075273755: _v := &ConditionMinLevel{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("condition.MinLevel") } else { return _v, nil }
        case 700922899: _v := &ConditionMaxLevel{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("condition.MaxLevel") } else { return _v, nil }
        case 907499647: _v := &ConditionMinMaxLevel{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("condition.MinMaxLevel") } else { return _v, nil }
        case 696630835: _v := &ConditionClothesPropertyScoreGreaterThan{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("condition.ClothesPropertyScoreGreaterThan") } else { return _v, nil }
        case 1961145317: _v := &ConditionContainsItem{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("condition.ContainsItem") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}

