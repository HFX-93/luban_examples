
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiIntKeyData struct {
    Value int32
}

const TypeId_AiIntKeyData = -342751904

func (*AiIntKeyData) GetTypeId() int32 {
    return -342751904
}

func (_v *AiIntKeyData)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["value"].(float64); !_ok_ { err = errors.New("value error"); return }; _v.Value = int32(_tempNum_) }
    return
}

func DeserializeAiIntKeyData(_buf map[string]interface{}) (*AiIntKeyData, error) {
    v := &AiIntKeyData{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
