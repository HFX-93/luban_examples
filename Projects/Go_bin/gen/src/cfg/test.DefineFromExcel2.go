
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
import "bright/math"

type TestDefineFromExcel2 struct {
    Id int32
    X1 bool
    X5 int64
    X6 float32
    X8 int32
    X10 string
    X13 int32
    X14 interface{}
    V2 math.Vector2
    T1 int32
    K1 []int32
    K8 map[int32]int32
    K9 []*TestDemoE2
}

const TypeId_TestDefineFromExcel2 = 688816828

func (*TestDefineFromExcel2) GetTypeId() int32 {
    return 688816828
}

func (_v *TestDefineFromExcel2)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestDefineFromExcel2)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _v.X1, err = _buf.ReadBool(); err != nil { err = errors.New("_v.X1 error"); err = errors.New("_v.X1 error"); return } }
    { if _v.X5, err = _buf.ReadLong(); err != nil { err = errors.New("_v.X5 error"); return } }
    { if _v.X6, err = _buf.ReadFloat(); err != nil { err = errors.New("_v.X6 error"); return } }
    { if _v.X8, err = _buf.ReadInt(); err != nil { err = errors.New("_v.X8 error"); return } }
    { if _v.X10, err = _buf.ReadString(); err != nil { err = errors.New("_v.X10 error"); return } }
    { if _v.X13, err = _buf.ReadInt(); err != nil { err = errors.New("_v.X13 error"); return } }
    { if _v.X14, err = DeserializeTestDemoDynamic(_buf); err != nil { err = errors.New("_v.X14 error"); return } }
    { if _v.V2, err = _buf.ReadVector2(); err != nil { err = errors.New("_v.V2 error"); return } }
    { if _v.T1, err = _buf.ReadInt(); err != nil { err = errors.New("_v.T1 error"); return } }
    {_v.K1 = make([]int32, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.K1 error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ int32; { if _e_, err = _buf.ReadInt(); err != nil { err = errors.New("_e_ error"); return } }; _v.K1 = append(_v.K1, _e_) } }
    { _v.K8 = make(map[int32]int32); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.K8 error"); return}; for i := 0 ; i < _n_ ; i++ { var _key_ int32; { if _key_, err = _buf.ReadInt(); err != nil { err = errors.New("_key_ error"); return } }; var _value_ int32; { if _value_, err = _buf.ReadInt(); err != nil { err = errors.New("_value_ error"); return } }; _v.K8[_key_] = _value_} }
    {_v.K9 = make([]*TestDemoE2, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.K9 error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ *TestDemoE2; { if _e_, err = DeserializeTestDemoE2(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.K9 = append(_v.K9, _e_) } }
    return
}

func DeserializeTestDefineFromExcel2(_buf *serialization.ByteBuf) (*TestDefineFromExcel2, error) {
    v := &TestDefineFromExcel2{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
