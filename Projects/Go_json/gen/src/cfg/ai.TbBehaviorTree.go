
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type AiTbBehaviorTree struct {
    _dataMap map[int32]*AiBehaviorTree
    _dataList []*AiBehaviorTree
}

func NewAiTbBehaviorTree(_buf []map[string]interface{}) (*AiTbBehaviorTree, error) {
	_dataList := make([]*AiBehaviorTree, 0, len(_buf))
	dataMap := make(map[int32]*AiBehaviorTree)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeAiBehaviorTree(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &AiTbBehaviorTree{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *AiTbBehaviorTree) GetDataMap() map[int32]*AiBehaviorTree {
    return table._dataMap
}

func (table *AiTbBehaviorTree) GetDataList() []*AiBehaviorTree {
    return table._dataList
}

func (table *AiTbBehaviorTree) Get(key int32) *AiBehaviorTree {
    return table._dataMap[key]
}


