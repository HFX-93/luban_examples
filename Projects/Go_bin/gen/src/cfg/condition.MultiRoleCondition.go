
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

type ConditionMultiRoleCondition struct {
    Conditions []interface{}
}

const TypeId_ConditionMultiRoleCondition = 934079583

func (*ConditionMultiRoleCondition) GetTypeId() int32 {
    return 934079583
}

func (_v *ConditionMultiRoleCondition)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *ConditionMultiRoleCondition)Deserialize(_buf *serialization.ByteBuf) (err error) {
    {_v.Conditions = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Conditions error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeConditionRoleCondition(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Conditions = append(_v.Conditions, _e_) } }
    return
}

func DeserializeConditionMultiRoleCondition(_buf *serialization.ByteBuf) (*ConditionMultiRoleCondition, error) {
    v := &ConditionMultiRoleCondition{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
