
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestTestString struct {
    Id int32
    S1 string
    Cs1 *TestCompactString
    Cs2 *TestCompactString
}

const TypeId_TestTestString = 338485823

func (*TestTestString) GetTypeId() int32 {
    return 338485823
}

func (_v *TestTestString)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.S1, _ok_ = _buf["s1"].(string); !_ok_ { err = errors.New("s1 error"); return } }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["cs1"].(map[string]interface{}); !_ok_ { err = errors.New("cs1 error"); return }; if _v.Cs1, err = DeserializeTestCompactString(_x_); err != nil { return } }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["cs2"].(map[string]interface{}); !_ok_ { err = errors.New("cs2 error"); return }; if _v.Cs2, err = DeserializeTestCompactString(_x_); err != nil { return } }
    return
}

func DeserializeTestTestString(_buf map[string]interface{}) (*TestTestString, error) {
    v := &TestTestString{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
