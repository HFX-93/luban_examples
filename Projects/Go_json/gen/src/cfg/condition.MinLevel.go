
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type ConditionMinLevel struct {
    Level int32
}

const TypeId_ConditionMinLevel = -1075273755

func (*ConditionMinLevel) GetTypeId() int32 {
    return -1075273755
}

func (_v *ConditionMinLevel)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["level"].(float64); !_ok_ { err = errors.New("level error"); return }; _v.Level = int32(_tempNum_) }
    return
}

func DeserializeConditionMinLevel(_buf map[string]interface{}) (*ConditionMinLevel, error) {
    v := &ConditionMinLevel{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
