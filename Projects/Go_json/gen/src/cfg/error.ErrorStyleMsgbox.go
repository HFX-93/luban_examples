
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type ErrorErrorStyleMsgbox struct {
    BtnName string
    Operation int32
}

const TypeId_ErrorErrorStyleMsgbox = -1920482343

func (*ErrorErrorStyleMsgbox) GetTypeId() int32 {
    return -1920482343
}

func (_v *ErrorErrorStyleMsgbox)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.BtnName, _ok_ = _buf["btn_name"].(string); !_ok_ { err = errors.New("btn_name error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["operation"].(float64); !_ok_ { err = errors.New("operation error"); return }; _v.Operation = int32(_tempNum_) }
    return
}

func DeserializeErrorErrorStyleMsgbox(_buf map[string]interface{}) (*ErrorErrorStyleMsgbox, error) {
    v := &ErrorErrorStyleMsgbox{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
