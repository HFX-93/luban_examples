
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type TagTbTestTag struct {
    _dataMap map[int32]*TagTestTag
    _dataList []*TagTestTag
}

func NewTagTbTestTag(_buf []map[string]interface{}) (*TagTbTestTag, error) {
	_dataList := make([]*TagTestTag, 0, len(_buf))
	dataMap := make(map[int32]*TagTestTag)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeTagTestTag(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &TagTbTestTag{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *TagTbTestTag) GetDataMap() map[int32]*TagTestTag {
    return table._dataMap
}

func (table *TagTbTestTag) GetDataList() []*TagTestTag {
    return table._dataList
}

func (table *TagTbTestTag) Get(key int32) *TagTestTag {
    return table._dataMap[key]
}


