
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestDemoE2 struct {
    Y1 *int32
    Y2 bool
}

const TypeId_TestDemoE2 = -2138341716

func (*TestDemoE2) GetTypeId() int32 {
    return -2138341716
}

func (_v *TestDemoE2)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var __json_y1__ interface{}; if __json_y1__, _ok_ = _buf["y1"]; !_ok_ || __json_y1__ == nil { return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_y1__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.Y1 = &__x__ }}
    { var _ok_ bool; if _v.Y2, _ok_ = _buf["y2"].(bool); !_ok_ { err = errors.New("y2 error"); return } }
    return
}

func DeserializeTestDemoE2(_buf map[string]interface{}) (*TestDemoE2, error) {
    v := &TestDemoE2{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
