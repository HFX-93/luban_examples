
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

type BonusDropBonus struct {
    Id int32
}

const TypeId_BonusDropBonus = 1959868225

func (*BonusDropBonus) GetTypeId() int32 {
    return 1959868225
}

func (_v *BonusDropBonus)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BonusDropBonus)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    return
}

func DeserializeBonusDropBonus(_buf *serialization.ByteBuf) (*BonusDropBonus, error) {
    v := &BonusDropBonus{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
