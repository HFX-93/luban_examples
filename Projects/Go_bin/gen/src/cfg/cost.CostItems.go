
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

type CostCostItems struct {
    ItemList []*CostCostItem
}

const TypeId_CostCostItems = -77945102

func (*CostCostItems) GetTypeId() int32 {
    return -77945102
}

func (_v *CostCostItems)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *CostCostItems)Deserialize(_buf *serialization.ByteBuf) (err error) {
    {_v.ItemList = make([]*CostCostItem, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.ItemList error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ *CostCostItem; { if _e_, err = DeserializeCostCostItem(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.ItemList = append(_v.ItemList, _e_) } }
    return
}

func DeserializeCostCostItems(_buf *serialization.ByteBuf) (*CostCostItems, error) {
    v := &CostCostItems{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
