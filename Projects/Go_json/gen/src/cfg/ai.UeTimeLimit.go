
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiUeTimeLimit struct {
    Id int32
    NodeName string
    FlowAbortMode int32
    LimitTime float32
}

const TypeId_AiUeTimeLimit = 338469720

func (*AiUeTimeLimit) GetTypeId() int32 {
    return 338469720
}

func (_v *AiUeTimeLimit)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.NodeName, _ok_ = _buf["node_name"].(string); !_ok_ { err = errors.New("node_name error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["flow_abort_mode"].(float64); !_ok_ { err = errors.New("flow_abort_mode error"); return }; _v.FlowAbortMode = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["limit_time"].(float64); !_ok_ { err = errors.New("limit_time error"); return }; _v.LimitTime = float32(_tempNum_) }
    return
}

func DeserializeAiUeTimeLimit(_buf map[string]interface{}) (*AiUeTimeLimit, error) {
    v := &AiUeTimeLimit{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
