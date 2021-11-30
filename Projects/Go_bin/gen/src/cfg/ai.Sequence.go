
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

type AiSequence struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
    Children []interface{}
}

const TypeId_AiSequence = -1789006105

func (*AiSequence) GetTypeId() int32 {
    return -1789006105
}

func (_v *AiSequence)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiSequence)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("_v.NodeName error"); return } }
    {_v.Decorators = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Decorators error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeAiDecorator(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Decorators = append(_v.Decorators, _e_) } }
    {_v.Services = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Services error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeAiService(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Services = append(_v.Services, _e_) } }
    {_v.Children = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Children error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeAiFlowNode(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Children = append(_v.Children, _e_) } }
    return
}

func DeserializeAiSequence(_buf *serialization.ByteBuf) (*AiSequence, error) {
    v := &AiSequence{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
