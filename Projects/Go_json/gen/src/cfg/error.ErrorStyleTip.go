
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg



type ErrorErrorStyleTip struct {
}

const TypeId_ErrorErrorStyleTip = 1915239884

func (*ErrorErrorStyleTip) GetTypeId() int32 {
    return 1915239884
}

func (_v *ErrorErrorStyleTip)Deserialize(_buf map[string]interface{}) (err error) {
    return
}

func DeserializeErrorErrorStyleTip(_buf map[string]interface{}) (*ErrorErrorStyleTip, error) {
    v := &ErrorErrorStyleTip{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
