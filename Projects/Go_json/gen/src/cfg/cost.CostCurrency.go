
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type CostCostCurrency struct {
    Type int32
    Num int32
}

const TypeId_CostCostCurrency = 911838111

func (*CostCostCurrency) GetTypeId() int32 {
    return 911838111
}

func (_v *CostCostCurrency)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["type"].(float64); !_ok_ { err = errors.New("type error"); return }; _v.Type = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["num"].(float64); !_ok_ { err = errors.New("num error"); return }; _v.Num = int32(_tempNum_) }
    return
}

func DeserializeCostCostCurrency(_buf map[string]interface{}) (*CostCostCurrency, error) {
    v := &CostCostCurrency{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
