
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

type TestDemoD2 struct {
    X1 int32
    X2 int32
}

const TypeId_TestDemoD2 = -2138341747

func (*TestDemoD2) GetTypeId() int32 {
    return -2138341747
}

func (_v *TestDemoD2)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestDemoD2)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.X1, err = _buf.ReadInt(); err != nil { err = errors.New("_v.X1 error"); return } }
    { if _v.X2, err = _buf.ReadInt(); err != nil { err = errors.New("_v.X2 error"); return } }
    return
}

func DeserializeTestDemoD2(_buf *serialization.ByteBuf) (*TestDemoD2, error) {
    v := &TestDemoD2{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
