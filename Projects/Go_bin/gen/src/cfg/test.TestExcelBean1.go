
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

type TestTestExcelBean1 struct {
    X1 int32
    X2 string
    X3 int32
    X4 float32
}

const TypeId_TestTestExcelBean1 = -1738345160

func (*TestTestExcelBean1) GetTypeId() int32 {
    return -1738345160
}

func (_v *TestTestExcelBean1)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestTestExcelBean1)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.X1, err = _buf.ReadInt(); err != nil { err = errors.New("_v.X1 error"); return } }
    { if _v.X2, err = _buf.ReadString(); err != nil { err = errors.New("_v.X2 error"); return } }
    { if _v.X3, err = _buf.ReadInt(); err != nil { err = errors.New("_v.X3 error"); return } }
    { if _v.X4, err = _buf.ReadFloat(); err != nil { err = errors.New("_v.X4 error"); return } }
    return
}

func DeserializeTestTestExcelBean1(_buf *serialization.ByteBuf) (*TestTestExcelBean1, error) {
    v := &TestTestExcelBean1{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
