
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BonusShowItemInfo struct {
    ItemId int32
    ItemNum int64
}

const TypeId_BonusShowItemInfo = -1496363507

func (*BonusShowItemInfo) GetTypeId() int32 {
    return -1496363507
}

func (_v *BonusShowItemInfo)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["item_id"].(float64); !_ok_ { err = errors.New("item_id error"); return }; _v.ItemId = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["item_num"].(float64); !_ok_ { err = errors.New("item_num error"); return }; _v.ItemNum = int64(_tempNum_) }
    return
}

func DeserializeBonusShowItemInfo(_buf map[string]interface{}) (*BonusShowItemInfo, error) {
    v := &BonusShowItemInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
