
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "luban_examples/go_bin/bright/serialization"
)

import "errors"

type CostCost struct {
}

const TypeId_CostCost = -316635794

func (*CostCost) GetTypeId() int32 {
    return -316635794
}

func (_v *CostCost)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *CostCost)Deserialize(_buf *serialization.ByteBuf) (err error) {
    return
}

func DeserializeCostCost(_buf *serialization.ByteBuf) (interface{}, error) {
    var id int32
    var err error
    if id, err = _buf.ReadInt() ; err != nil {
        return nil, err
    }
    switch id {
        case 911838111: _v := &CostCostCurrency{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("cost.CostCurrency") } else { return _v, nil }
        case 103084157: _v := &CostCostCurrencies{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("cost.CostCurrencies") } else { return _v, nil }
        case -1033587381: _v := &CostCostOneItem{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("cost.CostOneItem") } else { return _v, nil }
        case -1249440351: _v := &CostCostItem{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("cost.CostItem") } else { return _v, nil }
        case -77945102: _v := &CostCostItems{}; if err = _v.Deserialize(_buf); err != nil { return nil, errors.New("cost.CostItems") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}

