//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiKeyData struct {
}

const TypeId_AiKeyData = 1022478019

func (*AiKeyData) GetTypeId() int32 {
    return 1022478019
}

func (_v *AiKeyData)Deserialize(_buf map[string]interface{}) (err error) {
    return
}

func DeserializeAiKeyData(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["$type"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "FloatKeyData": _v := &AiFloatKeyData{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.FloatKeyData") } else { return _v, nil }
        case "IntKeyData": _v := &AiIntKeyData{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.IntKeyData") } else { return _v, nil }
        case "StringKeyData": _v := &AiStringKeyData{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.StringKeyData") } else { return _v, nil }
        case "BlackboardKeyData": _v := &AiBlackboardKeyData{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.BlackboardKeyData") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}
