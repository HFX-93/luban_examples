
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestSepVector struct {
    X int32
    Y int32
    Z int32
}

const TypeId_TestSepVector = 252769477

func (*TestSepVector) GetTypeId() int32 {
    return 252769477
}

func (_v *TestSepVector)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x"].(float64); !_ok_ { err = errors.New("x error"); return }; _v.X = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["y"].(float64); !_ok_ { err = errors.New("y error"); return }; _v.Y = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["z"].(float64); !_ok_ { err = errors.New("z error"); return }; _v.Z = int32(_tempNum_) }
    return
}

func DeserializeTestSepVector(_buf map[string]interface{}) (*TestSepVector, error) {
    v := &TestSepVector{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
