
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



type AiIsNotSet struct {
}

const TypeId_AiIsNotSet = 790736255

func (*AiIsNotSet) GetTypeId() int32 {
    return 790736255
}

func (_v *AiIsNotSet)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiIsNotSet)Deserialize(_buf *serialization.ByteBuf) (err error) {
    return
}

func DeserializeAiIsNotSet(_buf *serialization.ByteBuf) (*AiIsNotSet, error) {
    v := &AiIsNotSet{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
