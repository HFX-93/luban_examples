
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type TestTbMultiRowTitle struct {
    _dataMap map[int32]*TestMultiRowTitle
    _dataList []*TestMultiRowTitle
}

func NewTestTbMultiRowTitle(_buf []map[string]interface{}) (*TestTbMultiRowTitle, error) {
	_dataList := make([]*TestMultiRowTitle, 0, len(_buf))
	dataMap := make(map[int32]*TestMultiRowTitle)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeTestMultiRowTitle(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &TestTbMultiRowTitle{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *TestTbMultiRowTitle) GetDataMap() map[int32]*TestMultiRowTitle {
    return table._dataMap
}

func (table *TestTbMultiRowTitle) GetDataList() []*TestMultiRowTitle {
    return table._dataList
}

func (table *TestTbMultiRowTitle) Get(key int32) *TestMultiRowTitle {
    return table._dataMap[key]
}


