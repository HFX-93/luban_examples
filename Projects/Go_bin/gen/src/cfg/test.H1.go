
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

type TestH1 struct {
    Y2 *TestH2
    Y3 int32
}

const TypeId_TestH1 = -1422503995

func (*TestH1) GetTypeId() int32 {
    return -1422503995
}

func (_v *TestH1)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestH1)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Y2, err = DeserializeTestH2(_buf); err != nil { err = errors.New("_v.Y2 error"); return } }
    { if _v.Y3, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Y3 error"); return } }
    return
}

func DeserializeTestH1(_buf *serialization.ByteBuf) (*TestH1, error) {
    v := &TestH1{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
