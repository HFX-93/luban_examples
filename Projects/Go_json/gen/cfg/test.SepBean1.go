
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestSepBean1 struct {
    A int32
    B int32
    C string
}

const TypeId_TestSepBean1 = -1534339393

func (*TestSepBean1) GetTypeId() int32 {
    return -1534339393
}

func (_v *TestSepBean1)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["a"].(float64); !_ok_ { err = errors.New("a error"); return }; _v.A = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["b"].(float64); !_ok_ { err = errors.New("b error"); return }; _v.B = int32(_tempNum_) }
    { var _ok_ bool; if _v.C, _ok_ = _buf["c"].(string); !_ok_ { err = errors.New("c error"); return } }
    return
}

func DeserializeTestSepBean1(_buf map[string]interface{}) (*TestSepBean1, error) {
    v := &TestSepBean1{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
