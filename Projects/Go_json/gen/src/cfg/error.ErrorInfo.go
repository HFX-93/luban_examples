
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type ErrorErrorInfo struct {
    Code string
    Desc string
    Style interface{}
}

const TypeId_ErrorErrorInfo = 1389347408

func (*ErrorErrorInfo) GetTypeId() int32 {
    return 1389347408
}

func (_v *ErrorErrorInfo)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.Code, _ok_ = _buf["code"].(string); !_ok_ { err = errors.New("code error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["style"].(map[string]interface{}); !_ok_ { err = errors.New("style error"); return }; if _v.Style, err = DeserializeErrorErrorStyle(_x_); err != nil { return } }
    return
}

func DeserializeErrorErrorInfo(_buf map[string]interface{}) (*ErrorErrorInfo, error) {
    v := &ErrorErrorInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
