
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type ItemChooseOneBonus struct {
    DropId int32
    IsUnique bool
}

const TypeId_ItemChooseOneBonus = 228058347

func (*ItemChooseOneBonus) GetTypeId() int32 {
    return 228058347
}

func (_v *ItemChooseOneBonus)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["drop_id"].(float64); !_ok_ { err = errors.New("drop_id error"); return }; _v.DropId = int32(_tempNum_) }
    { var _ok_ bool; if _v.IsUnique, _ok_ = _buf["is_unique"].(bool); !_ok_ { err = errors.New("is_unique error"); return } }
    return
}

func DeserializeItemChooseOneBonus(_buf map[string]interface{}) (*ItemChooseOneBonus, error) {
    v := &ItemChooseOneBonus{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
