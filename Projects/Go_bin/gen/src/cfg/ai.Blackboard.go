
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

type AiBlackboard struct {
    Name string
    Desc string
    ParentName string
    Keys []*AiBlackboardKey
}

const TypeId_AiBlackboard = 1576193005

func (*AiBlackboard) GetTypeId() int32 {
    return 1576193005
}

func (_v *AiBlackboard)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiBlackboard)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Name, err = _buf.ReadString(); err != nil { err = errors.New("_v.Name error"); return } }
    { if _v.Desc, err = _buf.ReadString(); err != nil { err = errors.New("_v.Desc error"); return } }
    { if _v.ParentName, err = _buf.ReadString(); err != nil { err = errors.New("_v.ParentName error"); return } }
    {_v.Keys = make([]*AiBlackboardKey, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Keys error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ *AiBlackboardKey; { if _e_, err = DeserializeAiBlackboardKey(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Keys = append(_v.Keys, _e_) } }
    return
}

func DeserializeAiBlackboard(_buf *serialization.ByteBuf) (*AiBlackboard, error) {
    v := &AiBlackboard{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
