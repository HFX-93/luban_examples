
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

type TestInnerGroup struct {
    Y1 int32
    Y2 int32
    Y3 int32
    Y4 int32
}

const TypeId_TestInnerGroup = -587873083

func (*TestInnerGroup) GetTypeId() int32 {
    return -587873083
}

func (_v *TestInnerGroup)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestInnerGroup)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Y1, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Y1 error"); return } }
    { if _v.Y2, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Y2 error"); return } }
    { if _v.Y3, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Y3 error"); return } }
    { if _v.Y4, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Y4 error"); return } }
    return
}

func DeserializeTestInnerGroup(_buf *serialization.ByteBuf) (*TestInnerGroup, error) {
    v := &TestInnerGroup{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
