
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

type BonusWeightItemInfo struct {
    ItemId int32
    Num int32
    Weight int32
}

const TypeId_BonusWeightItemInfo = 1239999176

func (*BonusWeightItemInfo) GetTypeId() int32 {
    return 1239999176
}

func (_v *BonusWeightItemInfo)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BonusWeightItemInfo)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.ItemId, err = _buf.ReadInt(); err != nil { err = errors.New("_v.ItemId error"); return } }
    { if _v.Num, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Num error"); return } }
    { if _v.Weight, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Weight error"); return } }
    return
}

func DeserializeBonusWeightItemInfo(_buf *serialization.ByteBuf) (*BonusWeightItemInfo, error) {
    v := &BonusWeightItemInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
