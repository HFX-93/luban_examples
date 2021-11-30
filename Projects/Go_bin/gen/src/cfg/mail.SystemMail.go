
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

type MailSystemMail struct {
    Id int32
    Title string
    Sender string
    Content string
    Award []int32
}

const TypeId_MailSystemMail = 1214073149

func (*MailSystemMail) GetTypeId() int32 {
    return 1214073149
}

func (_v *MailSystemMail)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *MailSystemMail)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _v.Title, err = _buf.ReadString(); err != nil { err = errors.New("_v.Title error"); return } }
    { if _v.Sender, err = _buf.ReadString(); err != nil { err = errors.New("_v.Sender error"); return } }
    { if _v.Content, err = _buf.ReadString(); err != nil { err = errors.New("_v.Content error"); return } }
    {_v.Award = make([]int32, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Award error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ int32; { if _e_, err = _buf.ReadInt(); err != nil { err = errors.New("_e_ error"); return } }; _v.Award = append(_v.Award, _e_) } }
    return
}

func DeserializeMailSystemMail(_buf *serialization.ByteBuf) (*MailSystemMail, error) {
    v := &MailSystemMail{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
