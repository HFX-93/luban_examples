
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "luban_examples/go_bin/bright/serialization"
)

import "errors"

type AiStringKeyData struct {
    Value string
}

const TypeId_AiStringKeyData = -307888654

func (*AiStringKeyData) GetTypeId() int32 {
    return -307888654
}

func (_v *AiStringKeyData)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiStringKeyData)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Value, err = _buf.ReadString(); err != nil { err = errors.New("_v.Value error"); return } }
    return
}

func DeserializeAiStringKeyData(_buf *serialization.ByteBuf) (*AiStringKeyData, error) {
    v := &AiStringKeyData{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
