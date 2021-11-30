
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

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

func (_v *MailSystemMail)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.Title, _ok_ = _buf["title"].(string); !_ok_ { err = errors.New("title error"); return } }
    { var _ok_ bool; if _v.Sender, _ok_ = _buf["sender"].(string); !_ok_ { err = errors.New("sender error"); return } }
    { var _ok_ bool; if _v.Content, _ok_ = _buf["content"].(string); !_ok_ { err = errors.New("content error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["award"].([]interface{}); !_ok_ { err = errors.New("award error"); return }

                _v.Award = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.Award = append(_v.Award, _list_v_)
                }
            }

    return
}

func DeserializeMailSystemMail(_buf map[string]interface{}) (*MailSystemMail, error) {
    v := &MailSystemMail{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
